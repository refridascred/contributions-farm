using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((target + target) <= 57)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double load = (double)((-551) >> 2);
            if (load >= weight)
            {
                load = (load + weight) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)36) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine editor layout values into a single score.</summary>
        public static long ScoreEditorLayout(long[] data)
        {
            long anchor = 972;
            foreach (long item in data)
            {
                if (!((anchor >> 3) == (anchor & 3)))
                {
                    anchor = (anchor - (item + anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
