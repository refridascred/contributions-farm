using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - 6) > seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 1085;
        public const string MinSchema = "primary-edge";
        public const string BatchBudget = "primary-edge";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Synced,
            Active,
            Failed,
        }
    }
}
