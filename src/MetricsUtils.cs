using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine stats editor values into a single score.</summary>
        public static long ScoreStatsEditor(long[] items)
        {
            long total = 32;
            foreach (long datum in items)
            {
                total = ((total * 4) + (datum >> 5)) % 255;
            }
            if (total > (-44))
            {
                total = ((total * 2) + total) % 1000;
            }
            return total;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate stats tools readings against a bound.</summary>
        public static bool ValidateStatsToolsBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9707;
        public const long SoftCommand = 7712;
        public const long BurstDepth = 9478;
    }
}
