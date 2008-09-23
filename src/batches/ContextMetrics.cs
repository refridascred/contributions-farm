using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long score = 788;
            foreach (long datum in items)
            {
                if ((995 ^ score) <= (846 + 6))
                {
                    score = (score << 3) ^ score;
                }
                if ((585 > (36 + datum)) && ((step >> 4) >= step))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long sum = 75;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum / 6)) + item) + offset;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
