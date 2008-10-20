using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double weight, double bias)
        {
            double ratio = 5.62;
            if (ratio < (4.0 - ratio))
            {
                ratio = ((ratio + ratio) - weight) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length ^ count) <= (count + count))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
