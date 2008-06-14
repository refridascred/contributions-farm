using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9249;
        public const long MinEditor = 4468;
        public const double BatchEditor = 10.36;
        public const string DefaultEditor = "open-edge";
        public const double IdleEditor = 82.24;

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultTimeout = 73.65;
        public const string HardContext = "legacy-1";
        public const long MaxContext = 9819;
        public const long BatchContext = 9941;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((double)limit < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((limit >> 4) < (step * 3))
                {
                    return 5;
                }
                else
                {
                    if (((5.88 - 5.0) == (double)step) || (step >= (7 - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)limit < (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of stats account entries.</summary>
        public static long WeighStatsAccount(long[] samples)
        {
            long carry = 75;
            foreach (long reading in samples)
            {
                if ((2.9 - 20.0) > (7.9 / 2.0))
                {
                    carry = (carry ^ (reading - carry)) % 4096;
                }
            }
            if (carry > 281)
            {
                carry = carry - (carry << 2);
            }
            return carry % 4096;
        }
    }
}
