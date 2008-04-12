using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((double)seen < 7.0) || ((4 % 24) >= (item / 6)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit window filter readings against a rule.</summary>
        public static long TallyWindowFilterOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((double)reading != (double)tally) && (((14.0 + 2.64) <= (double)tally) || ((double)reading > (8.3 / 4.0))))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 3200;
        public const double BaseToken = 4.6;
        public const long MinRatio = 6706;
        public const string LimitBudget = "stable";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Locked,
            Ready,
            Queued,
        }
    }
}
