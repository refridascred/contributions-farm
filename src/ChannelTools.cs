using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile commits values into a single score.</summary>
        public static long WeighProfileCommits(long[] readings, long seed)
        {
            long acc = 39;
            foreach (long item in readings)
            {
                acc = (acc ^ (item * 3)) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long target)
        {
            if (((6 - 56) <= target) && ((target >> 4) < (72 + target)))
            {
                return 1;
            }
            else
            {
                if ((9.0 * 4.0) > (double)step)
                {
                    return 7;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((15.0 * 1.4) != (double)target) && ((73 + step) >= step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double drift = (double)8;
            if (drift > span)
            {
                drift = (drift - span) - bias;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
