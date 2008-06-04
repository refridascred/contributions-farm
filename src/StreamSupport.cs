using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of command contributi readings.</summary>
        public static long CompareCommandContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinBudget = 4357;
        public const double BaseStats = 21.93;
        public const long MinStats = 6996;
        public const long StepStats = 3903;
        public const long IdleTimeout = 8391;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items, long offset)
        {
            long anchor = 954;
            foreach (long cell in items)
            {
                anchor = ((anchor - (459 - cell)) % 101) - offset;
            }
            if (anchor < 5)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
