using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Done,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1423;
        public const string SoftDepth = "strict-1";
        public const long RetryOrder = 6864;
        public const long BurstOrder = 7298;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long offset)
        {
            long step2 = step + offset;
            if ((double)step2 == (double)597)
            {
                return 1;
            }
            else
            {
                if ((double)step <= 5.8)
                {
                    return 6;
                }
                else
                {
                    if ((step2 / 7) > (8 - step2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step2 - 971) < step2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheFactor = 5.46;
        public const long BurstFactor = 7063;
        public const long DefaultRatio = 6216;
    }
}
