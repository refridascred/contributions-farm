using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items)
        {
            long acc = 888;
            foreach (long reading in items)
            {
                acc = (acc ^ acc) % 255;
                if ((acc - reading) <= (acc >> 4))
                {
                    acc = ((acc << 3) ^ ((long)items.Length * 5)) % 1000;
                }
                if ((double)reading >= 6.07)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
