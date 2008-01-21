using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((-25) - hits) < 0)
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long bound)
        {
            long sum = 158;
            foreach (long sample in levels)
            {
                if ((1.7 / 9.0) == (double)bound)
                {
                    sum = (sum ^ bound) + sample;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Queued,
            Ready,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
