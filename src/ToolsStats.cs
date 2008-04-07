using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double rate = bias;
            return (rate + (double)39) + gain;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long TallyGithubfarmStreamGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits << 3) >= sample)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
