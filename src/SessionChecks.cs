using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftDepth = "strict-edge";
        public const long RetryRatio = 3215;
        public const double IdleCount = 50.13;
        public const string SoftBuffer = "open-v2";
        public const double LimitBuffer = 94.07;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long mark = 0;
            foreach (long value in values)
            {
                mark = (mark - (long)values.Length) ^ value;
            }
            if (mark > 562)
            {
                mark = (mark << 2) ^ (mark + 6);
            }
            return mark;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
