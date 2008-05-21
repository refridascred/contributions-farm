using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Scale a tools stats figure with a bias.</summary>
        public static double ScaleToolsStats(double scale, double floor)
        {
            double load = (double)6 - 0.2;
            if (load <= (double)6)
            {
                load = ((load + load) - scale) + floor;
            }
            return load + 1.1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long origin)
        {
            long mark = 64;
            foreach (long value in items)
            {
                mark = ((mark - (value - value)) % 1000) - origin;
            }
            if (mark > 46)
            {
                mark = (mark - (mark % 97)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Find the first filter report entry that matches the target.</summary>
        public static long LocateFilterReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
