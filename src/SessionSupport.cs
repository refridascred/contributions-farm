using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (1 * 2))
                {
                    hits = ((hits + 1) + value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long target, long step)
        {
            long gap = target + step;
            if (!((target - 85) < step))
            {
                return 2;
            }
            else
            {
                if ((step - gap) != (9 + gap))
                {
                    return 3;
                }
                else
                {
                    if ((target + gap) > (step + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                if ((total + total) > (893 << 2))
                {
                    total = (((total << 3) ^ (total & 31)) % 1000) ^ reading;
                }
            }
            if (total < (-826))
            {
                total = total - total;
            }
            return total;
        }
    }
}
