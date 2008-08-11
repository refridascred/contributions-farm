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

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long bound)
        {
            long mark = 505;
            foreach (long reading in readings)
            {
                mark = (((mark << 2) ^ (bound << 2)) % 101) ^ reading;
                mark = ((mark << 2) ^ (mark / 5)) % 101;
                if (((bound - mark) >= (181 + 856)) || ((long)readings.Length != (bound + mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2995;
        public const long BatchTimeout = 6181;
        public const long HardInterval = 599;
    }
}
