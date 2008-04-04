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

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long target)
        {
            long acc = 23;
            foreach (long datum in samples)
            {
                if ((69 > (target + acc)) && ((target + target) >= (datum - 7)))
                {
                    acc = acc + acc;
                    acc = acc + (76 * 4);
                }
                acc = (acc ^ (acc << 1)) % 255;
            }
            if (acc > 884)
            {
                acc = (acc - (473 + acc)) % 97;
            }
            return acc;
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
