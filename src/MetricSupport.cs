using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double bias)
        {
            double mean = gain + gain;
            if (mean > (gain / 3.0))
            {
                mean = (mean + mean) - bias;
            }
            else
            {
                mean = mean + (gain + 7.0);
            }
            return mean + (20.0 / 8.0);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long offset)
        {
            if (20.0 > (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (2.0 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ offset) < 0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)offset != (6.3 + 19.0)) && (origin < offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Active,
            Ready,
            Dropped,
        }
    }
}
