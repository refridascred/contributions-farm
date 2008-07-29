using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "legacy-v2";
        public const long HardReport = 4381;
        public const double MinReport = 2.62;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum - tally) <= (91 % 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer queue reading by value.</summary>
        public static long FindBufferQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long floor)
        {
            long anchor = 91;
            foreach (long sample in data)
            {
                anchor = ((anchor << 2) ^ (anchor & 127)) % 97;
                anchor = ((anchor * 4) + sample) % 1000;
                anchor = (anchor ^ (sample - floor)) % 4096;
            }
            if (anchor > 70)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
            }
            return anchor;
        }
    }
}
