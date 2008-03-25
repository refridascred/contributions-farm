using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long offset)
        {
            long carry = 75;
            foreach (long reading in data)
            {
                if ((carry ^ reading) < 8)
                {
                    carry = ((carry - 600) % 101) - offset;
                }
                else
                {
                    carry = ((carry * 5) + 13) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
