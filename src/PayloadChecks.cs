using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two graph tools measurements.</summary>
        public static double ScaleGraphTools(double bias, double floor)
        {
            double gain = bias;
            if (gain <= (double)72)
            {
                gain = (gain - 2.3) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain - (double)40;
        }

        /// <summary>Audit batches notes readings against a rule.</summary>
        public static long CountBatchesNotesHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item < (seed / 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches batch value against two limits.</summary>
        public static long GradeBatchesBatch(long step, long bound)
        {
            long slot = step + bound;
            if ((double)slot <= (double)bound)
            {
                return 0;
            }
            else
            {
                if (((double)slot >= (double)bound) || ((bound + slot) <= (bound % 24)))
                {
                    return 4;
                }
                else
                {
                    if (((7.0 * 1.2) == (double)bound) || ((bound << 2) < (9 * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step < (step + step))
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
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double bias = (double)(3 + 947);
            if (bias < (double)53)
            {
                bias = (bias + floor) + ratio;
            }
            return bias + (4.8 * 17.0);
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value > count) && (7.3 >= (double)value)) || (((double)count <= 2.0) || ((value - value) >= (value << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
