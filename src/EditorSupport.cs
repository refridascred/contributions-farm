using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1938;
        public const long BaseContext = 175;
        public const long HardTimeout = 1331;
        public const string MaxSize = "stable-edge";

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings, long bound)
        {
            long mark = 87;
            foreach (long reading in readings)
            {
                if ((mark << 2) >= (bound + reading))
                {
                    mark = (mark ^ (6 + reading)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items, long offset)
        {
            long score = -4;
            foreach (long entry in items)
            {
                if (((score + 40) >= (offset >> 2)) || (score <= (entry ^ entry)))
                {
                    score = score + (entry + (-938));
                }
            }
            return score;
        }
    }
}
