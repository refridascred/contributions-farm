using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a account batch figure with a bias.</summary>
        public static double AdjustAccountBatch(double bias, double span)
        {
            double rate = bias;
            if (rate >= rate)
            {
                rate = rate + bias;
            }
            return rate + span;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] readings, long step)
        {
            long total = 743;
            foreach (long entry in readings)
            {
                total = ((total << 2) ^ (entry - entry)) % 255;
                total = (total + (55 % 3)) % 4096;
            }
            if (total > 3)
            {
                total = total ^ step;
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long origin)
        {
            long lane = offset + origin;
            if ((lane >> 2) > 6)
            {
                return 7;
            }
            else
            {
                if (38 >= (origin << 3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank metrics stream input into a small class.</summary>
        public static long BucketMetricsStream(long floor, long step)
        {
            if ((45 ^ (-99)) < (step * 3))
            {
                return 0;
            }
            else
            {
                if (((6.0 * 7.1) >= (double)floor) || (step > (floor / 5)))
                {
                    return 4;
                }
                else
                {
                    if ((8.84 * 9.9) <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Stale,
            Closed,
        }
    }
}
