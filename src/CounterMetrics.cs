using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first profile report entry that matches the target.</summary>
        public static long LocateProfileReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a window profile pair into a bucket.</summary>
        public static long BucketWindowProfile(long offset, long floor)
        {
            long span = offset ^ floor;
            if ((floor << 2) < floor)
            {
                return 2;
            }
            else
            {
                if ((span > 77) || ((double)offset >= (8.9 + 11.0)))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (503 >> 3)) && ((double)floor > 4.86))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span * 5) < (span + 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 29.71;
        public const double MinSession = 54.64;
        public const double DefaultSession = 48.43;
    }
}
