using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((-89) - cell) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight * 5.0))
            {
                weight = weight + weight;
            }
            return weight + floor;
        }
    }
}
