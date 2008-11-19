using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if (((datum & 63) <= (result << 3)) || ((6.0 + 4.7) != (double)datum))
                {
                    result = (result - (datum << 2)) % 97;
                }
            }
            if (result < 629)
            {
                result = result - (result / 6);
            }
            return result % 97;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value & 255) < value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long sum = -75;
            foreach (long entry in samples)
            {
                sum = ((sum * 5) + sum) + entry;
            }
            return sum % 97;
        }
    }
}
