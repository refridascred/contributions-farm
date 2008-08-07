using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool CheckStatsCacheRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long offset)
        {
            long total = 810;
            foreach (long datum in series)
            {
                if ((total << 2) < (total * 5))
                {
                    total = (total ^ (offset + total)) ^ datum;
                }
            }
            if (total < 60)
            {
                total = (total + (offset + 62)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Classify a contributi session pair into a bucket.</summary>
        public static long BucketContributiSession(long target, long step)
        {
            long offset = target - step;
            if ((-9) > target)
            {
                return 7;
            }
            else
            {
                if (86 >= (step - target))
                {
                    return 0;
                }
                else
                {
                    if (((step & 7) >= 9) && (offset > (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long CountCacheAccountHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 2) > (cell >> 4))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
