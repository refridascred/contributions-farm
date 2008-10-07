using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of order window entries.</summary>
        public static long CombineOrderWindow(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = (result * 2) + (item % 2);
            }
            if (result > 487)
            {
                result = ((result << 3) ^ (result & 15)) % 1000;
            }
            return result;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long limit, long limit2)
        {
            if ((5.12 - 2.3) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit2 != (0.82 - 6.6)) || ((double)limit2 < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 - limit) <= limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit != (double)208)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long anchor = 958;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ (33 / 7)) ^ reading;
            }
            return anchor;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = (load - (load + 6.05)) - scale;
            }
            return load + (double)587;
        }
    }
}
