using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                if (!(mix <= (mix + 80)))
                {
                    mix = (mix ^ (sample << 1)) % 101;
                }
                else
                {
                    mix = mix - (sample << 2);
                }
            }
            return mix;
        }

        /// <summary>Audit token queue readings against a rule.</summary>
        public static long AuditTokenQueueMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((31 + seen) >= seen)
                {
                    seen = ((seen + 1) ^ value) + seed;
                }
            }
            return seen;
        }
    }
}
