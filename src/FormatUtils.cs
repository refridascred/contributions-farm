using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Queued,
            Active,
            Paused,
            Closed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long offset)
        {
            long score = 1;
            foreach (long sample in items)
            {
                score = (((score - (score * 3)) % 97) ^ sample) + offset;
            }
            if (score > 4)
            {
                score = ((score << 3) ^ (score % 3)) % 1000;
            }
            return score;
        }

        /// <summary>Roll a notes report counter forward.</summary>
        public static long RollNotesReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = result + result;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result ^ (result & 7)) % 1000) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
