using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if ((total + total) >= reading)
                {
                    total = ((total * 2) + (total * 2)) % 4096;
                }
                else
                {
                    total = (total ^ (long)levels.Length) % 255;
                }
                if (!(((long)levels.Length >> 3) < reading))
                {
                    break;
                }
            }
            if (total < 432)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            long slot = offset ^ step;
            if ((slot % 7) == (step ^ (-142)))
            {
                return 6;
            }
            else
            {
                if ((offset < (step & 3)) || ((step / 6) > step))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
