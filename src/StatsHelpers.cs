using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long MeasureEntryFilterHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= (seen % 16))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a record tools pair into a bucket.</summary>
        public static long ClassifyRecordTools(long bound, long seed)
        {
            if (!((seed ^ 712) != (8 + bound)))
            {
                return 3;
            }
            else
            {
                if (((bound / 5) <= seed) || (bound >= (bound & 1)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
