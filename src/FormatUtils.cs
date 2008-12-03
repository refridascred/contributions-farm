using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Iterate the already batches series from a seed.</summary>
        public static long IterateAlreadyBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mix <= 3.38)
                {
                    mix = (mix - (origin + origin)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally > 7.1)
                {
                    tally = ((tally + 1) ^ value) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
