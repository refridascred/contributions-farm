using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((7.86 * 7.3) >= (double)seed)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (bound >> 2)) % 97;
                anchor = (anchor ^ (35 & 7)) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor + (96 ^ bound)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin ^ origin) <= origin)
                {
                    sum = (sum * 2) + (1 - origin);
                }
                if (!((origin + sum) > origin))
                {
                    sum = (sum - (sum + sum)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items)
        {
            long mark = 278;
            foreach (long item in items)
            {
                mark = ((mark - (6 / 7)) % 101) + item;
            }
            return mark % 97;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
