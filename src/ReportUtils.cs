using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items, long step)
        {
            long result = 474;
            foreach (long reading in items)
            {
                if ((reading >> 2) <= reading)
                {
                    result = ((result + 1) % 255) + step;
                }
                else
                {
                    result = (result ^ (result / 8)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= (6.2 + 6.07))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((749 < (cell - bound)) || ((cell - matches) <= (bound + matches))) && ((double)matches == (1.76 + 6.5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2995;
        public const long BatchTimeout = 6181;
        public const long HardInterval = 599;
    }
}
