using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((34 - item) != (item + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double weight = (double)36 * 5.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + 18.0) + (double)(long)i) + offset;
            }
            return weight + (bias * 1.1);
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Idle,
            Draft,
        }
    }
}
