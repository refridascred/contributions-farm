using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine batch command values into a single score.</summary>
        public static long ScoreBatchCommand(long[] series, long seed)
        {
            long result = -207;
            foreach (long value in series)
            {
                if ((22 >> 1) >= result)
                {
                    result = (result + value) - seed;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (5.1 >= (double)offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings)
        {
            long total = 72;
            foreach (long entry in readings)
            {
                if (((9.48 / 2.0) != (double)entry) && ((entry << 2) >= (entry ^ entry)))
                {
                    total = (total ^ entry) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
                if ((entry - total) >= (total - entry))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
