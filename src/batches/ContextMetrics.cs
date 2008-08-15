using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a route batches pair into a bucket.</summary>
        public static long GradeRouteBatches(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((double)seed > (8.9 * 0.6))
            {
                return 4;
            }
            else
            {
                if (!(edge >= (edge % 24)))
                {
                    return 1;
                }
                else
                {
                    if ((47 <= (edge >> 4)) && (edge < (seed >> 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge + floor) <= (edge & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats order samples.</summary>
        public static long CompareStatsOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
