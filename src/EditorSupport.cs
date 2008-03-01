using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            if ((seed - offset) <= (seed + offset))
            {
                return 8;
            }
            else
            {
                if (seed < (seed + offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 1) != (item ^ 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long target)
        {
            long slot = step ^ target;
            if ((double)slot < (5.5 + 9.3))
            {
                return 5;
            }
            else
            {
                if (!(step > (slot + 320)))
                {
                    return 4;
                }
                else
                {
                    if ((18.0 * 6.0) >= (double)slot)
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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Dropped,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < (bias + bias))
            {
                ratio = (ratio - ratio) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
