using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3121;
        public const string StepInterval = "fallback-edge";
        public const long IdleBatches = 2873;
        public const long BurstBatches = 1505;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((seed < (reading + reading)) || ((0.92 / 4.0) > (double)seed))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                anchor = ((anchor - (46 << 3)) ^ value) + step;
            }
            return anchor;
        }
    }
}
