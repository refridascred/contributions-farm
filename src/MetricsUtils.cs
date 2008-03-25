using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long limit)
        {
            if ((double)bound > (11.0 / 2.0))
            {
                return 0;
            }
            else
            {
                if ((6 << 3) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((2.1 + 6.1) >= (13.0 + 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double scale2 = (bias - 16.0) + (double)316;
            if (scale2 <= (scale2 * 2.09))
            {
                scale2 = scale2 - (bias * 9.9);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale) - (double)(long)i;
            }
            return scale2 + (bias / 8.0);
        }
    }
}
