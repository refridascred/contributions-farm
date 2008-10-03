using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next tools entry value.</summary>
        public static double ProjectToolsEntry(double ratio, double offset)
        {
            double scale = (17.0 * 6.84) * 0.45;
            if (scale >= (double)675)
            {
                scale = (scale + (9.84 + scale)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (offset - offset)) - (double)(long)i;
            }
            return scale + (double)32;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Locked,
            New,
        }
    }
}
