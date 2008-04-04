using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 668;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + (carry * 5)) % 255;
                if (((5.0 + 1.33) <= (double)carry) || (5 > (entry + (long)series.Length)))
                {
                    carry = ((carry * 3) + entry) % 1000;
                }
            }
            if (carry < 436)
            {
                carry = carry + carry;
            }
            return carry;
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

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
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
