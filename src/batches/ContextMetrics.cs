using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Rank graph checks input into a small class.</summary>
        public static long GradeGraphChecks(long floor, long seed)
        {
            if ((seed - seed) < (floor - seed))
            {
                return 6;
            }
            else
            {
                if ((floor - seed) == ((-97) * 4))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (51 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double bias2 = (double)(432 + 7);
            if (bias2 >= (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)49;
            }
            return bias2 - scale;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double gain, double offset)
        {
            double load = offset;
            if (load >= gain)
            {
                load = load + 7.13;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (0.6 / 5.0)) + (double)(long)i;
            }
            return load + 19.0;
        }
    }
}
