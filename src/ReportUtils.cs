using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((84 >> 2) != (entry >> 1))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long CountPayloadBatchMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (824 * 2))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
