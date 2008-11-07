using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of session checks readings.</summary>
        public static long ScoreSessionChecks(long[] samples, long bound)
        {
            long acc = 60;
            foreach (long cell in samples)
            {
                if ((double)cell == (3.24 - 3.8))
                {
                    acc = ((acc << 3) ^ (cell * 2)) - bound;
                }
            }
            return acc % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count % 8) < (652 - 788)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Queued,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long MeasureStreamSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((48 & 3) < value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally >> 1) <= (tally + entry))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
