using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long mix = 27;
            foreach (long value in samples)
            {
                mix = (((mix << 2) ^ mix) % 65521) - value;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 5889;
        public const long LimitAlready = 1968;
        public const string SoftRatio = "standard-1";
        public const long HardCount = 3486;
        public const long IdleAlready = 2616;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool VerifyCounterCommitsLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
