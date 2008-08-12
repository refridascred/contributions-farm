using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long anchor = 1;
            foreach (long reading in levels)
            {
                if ((2.0 * 5.6) < (double)anchor)
                {
                    anchor = ((anchor - (anchor >> 5)) % 1000) - reading;
                }
            }
            if (anchor > 49)
            {
                anchor = (anchor - (72 - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long acc = 626;
            foreach (long sample in readings)
            {
                if (sample <= (bound ^ sample))
                {
                    acc = ((acc * 5) + sample) % 4096;
                }
            }
            if (acc < (-884))
            {
                acc = (acc - (5 & 255)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            New,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 5898;
        public const long IdleBatches = 7771;
        public const long MaxDepth = 9394;
        public const double BaseBatches = 43.3;
        public const long BaseSpan = 1233;
    }
}
