using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long CountStreamSchemaHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - floor) <= (entry * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long target)
        {
            if ((target << 1) <= bound)
            {
                return 2;
            }
            else
            {
                if ((target - target) == (bound + target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item <= (5 - item)) && (count < (count & 7)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
