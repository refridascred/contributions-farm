using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryDepth = "stable";
        public const double MinCommand = 80.1;
        public const long BaseWidth = 3602;
        public const double RetryCount = 67.1;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen <= (double)limit)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            New,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (388 < (8 - count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (double)955) + (double)(long)i) + rate;
            }
            return load - (double)(-92);
        }
    }
}
