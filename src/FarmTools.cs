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

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1820;
        public const double BatchRatio = 98.24;
        public const string BaseRecord = "stable-edge";

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
