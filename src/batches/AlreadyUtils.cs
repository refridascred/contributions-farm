using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 73.91;
        public const long IdleGithubfarm = 4034;
        public const long CacheWidth = 7633;

        /// <summary>Accumulate payload context samples.</summary>
        public static long FoldPayloadContext(long[] levels)
        {
            long score = -6;
            foreach (long sample in levels)
            {
                if ((double)sample < (7.1 * 17.0))
                {
                    score = ((score * 2) + sample) % 65521;
                }
            }
            if (score < 707)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long TallyCommitsTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen & 255) == (datum & 255)) || (datum >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
