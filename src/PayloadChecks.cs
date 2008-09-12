using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two stats batch measurements.</summary>
        public static double SmoothStatsBatch(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= (bias2 / 8.0))
            {
                gain = gain - (double)7;
            }
            else
            {
                gain = gain - (double)58;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias2) - (double)(long)i;
            }
            return gain - (bias2 * 9.86);
        }

        /// <summary>Blend two metric already measurements.</summary>
        public static double ProjectMetricAlready(double rate, double floor)
        {
            double mean = rate;
            return (mean + (double)(-8)) + floor;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long origin)
        {
            long step = floor - origin;
            if ((double)origin >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (floor > step)
                {
                    return 1;
                }
                else
                {
                    if (((-803) + origin) == (0 ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - step) <= (origin >> 1)) || ((floor >> 1) < (73 % 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((-55) * 2) >= bound)
                {
                    state = ((state * 5) + (bound + (long)i)) % 65521;
                }
                else
                {
                    state = (state * 5) + state;
                    state = (state + (606 % 100)) % 101;
                }
                state = (state << 3) ^ (bound - 95);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            Synced,
            Pending,
            Paused,
        }
    }
}
