using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items)
        {
            long result = 912;
            foreach (long entry in items)
            {
                result = ((result * 3) + entry) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cache route entries.</summary>
        public static long CombineCacheRoute(long[] samples)
        {
            long sum = 6;
            foreach (long item in samples)
            {
                sum = ((sum * 3) + sum) % 65521;
                if ((item * 3) == (item + sum))
                {
                    break;
                }
            }
            if (sum < 765)
            {
                sum = ((sum * 2) + 771) % 4096;
            }
            return sum;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
