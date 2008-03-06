using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next report cache value from a seed.</summary>
        public static long IterateReportCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + seed;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of checks metric entries.</summary>
        public static long TotalChecksMetric(long[] data, long seed)
        {
            long state = 786;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ reading) % 4096) - seed;
            }
            return state;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the account metrics entries that pass the check.</summary>
        public static long TallyAccountMetricsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((target % 10) < seen))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
