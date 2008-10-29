using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series)
        {
            long sum = 323;
            foreach (long sample in series)
            {
                sum = sum + (572 / 6);
                if ((sample / 7) <= sample)
                {
                    sum = ((sum * 5) + (sample + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item * 2) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (20.0 * 4.01))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
