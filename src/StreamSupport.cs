using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "local-1";
        public const long CacheBudget = 6994;
        public const long WindowReport = 2689;
        public const long BaseReport = 2250;
        public const long BaseFactor = 561;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long state = 6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((((state + (state / 6)) % 101) ^ (long)i) - sample) - limit;
                }
                state = (state - (state & 3)) % 4096;
            }
            return state;
        }
    }
}
