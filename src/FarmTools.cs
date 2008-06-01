using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long origin2)
        {
            if (((double)origin <= (double)origin2) || ((5.5 + 3.4) <= (1.7 + 7.1)))
            {
                return 6;
            }
            else
            {
                if ((origin2 + origin) >= (origin2 >> 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double mean = offset * 20.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(long)i) - ratio;
            }
            return mean + mean;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
