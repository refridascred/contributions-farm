using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double ProjectMetricLayout(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 3.7) - (double)(long)i;
            }
            return ratio - (bias / 3.0);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long target, long origin)
        {
            long slot = target + origin;
            if (9 >= target)
            {
                return 2;
            }
            else
            {
                if ((target + target) < 6)
                {
                    return 0;
                }
                else
                {
                    if (((origin ^ target) == (slot << 1)) && ((slot ^ 160) > slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - origin) > origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
