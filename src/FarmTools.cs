using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long mix = 54;
            foreach (long entry in readings)
            {
                mix = ((mix - (entry / 8)) % 1000) + seed;
                if ((entry * 4) != (mix - 72))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5384;
        public const long BatchBudget = 3229;
        public const long WindowSize = 5086;
        public const long BatchRoute = 5016;
    }
}
