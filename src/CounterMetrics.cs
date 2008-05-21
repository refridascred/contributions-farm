using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Draft,
            Locked,
            New,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine token entry values into a single score.</summary>
        public static long TallyTokenEntry(long[] series, long origin)
        {
            long score = 33;
            foreach (long entry in series)
            {
                if (!((double)score != (0.52 + 5.98)))
                {
                    score = (score * 2) + (origin * 4);
                }
                else
                {
                    score = (score << 2) ^ (entry + origin);
                }
                if (!(score >= (score >> 4)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Closed,
            Done,
        }
    }
}
