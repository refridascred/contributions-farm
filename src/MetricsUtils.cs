using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Locate a cache support reading by value.</summary>
        public static long SeekCacheSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)mark == (5.22 / 6.0))
                {
                    mark = mark ^ (long)i;
                }
                mark = (mark - (bound - bound)) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + 44) < seen)
                {
                    seen = ((seen + 1) - datum) - limit;
                }
            }
            return seen;
        }
    }
}
