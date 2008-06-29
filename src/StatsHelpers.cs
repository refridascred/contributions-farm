using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items, long target)
        {
            long sum = 28;
            foreach (long reading in items)
            {
                if (((target + target) < (target + 7)) || ((double)reading != (12.0 / 9.0)))
                {
                    sum = (sum ^ (sum << 3)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (1 - sum);
                }
                if ((reading + reading) != (sum % 16))
                {
                    sum = (sum ^ (reading + reading)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command profile entries that pass the check.</summary>
        public static long AuditCommandProfileOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((1.1 / 9.0) > (double)limit)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long MeasureStreamOrderMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample - 9) != (712 / 9)) && (seen >= (limit + 28))) && ((sample / 2) > 99))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
