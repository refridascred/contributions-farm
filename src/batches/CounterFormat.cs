using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Count the schema already entries that pass the check.</summary>
        public static long AuditSchemaAlreadyOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches < (1.2 + 16.0))
                {
                    matches = ((matches + 1) - reading) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 2414;
        public const long DefaultWindow = 8616;
        public const double BurstWindow = 5.92;
    }
}
