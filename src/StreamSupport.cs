using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 676;
            foreach (long entry in samples)
            {
                if ((entry / 6) != (entry - entry))
                {
                    state = (state - (437 - state)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7719;
        public const long IdleLevel = 425;
        public const long MaxSupport = 9459;
        public const double WindowSupport = 23.18;
    }
}
