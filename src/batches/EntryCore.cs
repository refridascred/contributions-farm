using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Closed,
            Failed,
            New,
        }

        /// <summary>Project the next order githubfarm value.</summary>
        public static double SmoothOrderGithubfarm(double ratio, double offset)
        {
            double rate = (double)(4 + 66);
            return (rate - offset) + ratio;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((7 ^ datum) >= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits payload samples are out of range.</summary>
        public static long CountCommitsPayloadMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value > 0.2)
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
