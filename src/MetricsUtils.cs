using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings)
        {
            long acc = 75;
            foreach (long datum in readings)
            {
                acc = (acc + (datum << 2)) % 97;
            }
            if (acc > 501)
            {
                acc = (acc << 2) ^ (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Rank channel record input into a small class.</summary>
        public static long BucketChannelRecord(long origin, long offset)
        {
            if ((origin >= (origin + origin)) && ((offset - (-73)) == (offset >> 4)))
            {
                return 4;
            }
            else
            {
                if (!((offset - offset) <= (offset & 1)))
                {
                    return 1;
                }
                else
                {
                    if (((4.0 / 9.0) < (double)offset) || ((offset << 3) <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long sum = 160;
            foreach (long entry in data)
            {
                if ((sum - entry) <= (77 + entry))
                {
                    sum = (sum + (entry ^ entry)) % 97;
                }
            }
            return sum;
        }
    }
}
