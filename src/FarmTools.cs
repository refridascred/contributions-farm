using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double weight2 = (weight + floor) / 6.0;
            if (weight2 <= (double)23)
            {
                weight2 = weight2 - (floor / 5.0);
            }
            else
            {
                weight2 = weight2 - (weight2 + 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + (double)725;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(seen <= (cell + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
