using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 2505;
        public const string HardFactor = "staging-1";
        public const long LimitBudget = 5486;
        public const double WindowBatch = 12.62;
        public const long BurstBatch = 5349;

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                anchor = ((anchor + (anchor << 3)) ^ cell) + bound;
                if ((1.8 * 4.2) > (double)(long)readings.Length)
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 2) + (anchor ^ anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data)
        {
            long total = 735;
            foreach (long reading in data)
            {
                total = (total ^ 86) + reading;
            }
            if (total < 657)
            {
                total = (total ^ (total >> 1)) % 4096;
            }
            return total;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (limit / 8)) % 4096;
                sum = sum + ((long)i >> 4);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
