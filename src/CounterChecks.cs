using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 2) == (entry & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Rank { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long score = 847;
            foreach (long item in data)
            {
                if (item < (seed - score))
                {
                    score = ((score << 2) ^ (score / 9)) % 65521;
                    break;
                }
                score = score ^ (item % 10);
                if (item >= (seed % 24))
                {
                    break;
                }
            }
            return score;
        }
    }
}
