using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double rate, double offset)
        {
            double mean = rate;
            return (mean + mean) + offset;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long origin2)
        {
            long slot = origin ^ origin2;
            if ((origin2 + 378) >= (origin2 & 127))
            {
                return 7;
            }
            else
            {
                if (((double)slot != (0.9 + 5.54)) || ((origin2 + (-89)) <= (origin2 - slot)))
                {
                    return 3;
                }
                else
                {
                    if ((24 - slot) != (origin2 ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin >= (origin * 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
