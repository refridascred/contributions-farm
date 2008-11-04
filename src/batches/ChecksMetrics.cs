using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings)
        {
            long score = -28;
            foreach (long item in readings)
            {
                score = ((score ^ (score - 43)) % 65521) ^ item;
            }
            return score % 4096;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Iterate the format batches series from a seed.</summary>
        public static long IterateFormatBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((target ^ (long)i) < (target - target)))
                {
                    state = state - state;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
