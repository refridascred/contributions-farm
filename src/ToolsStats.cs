using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels)
        {
            long state = 4;
            foreach (long value in levels)
            {
                state = ((state ^ (state + (-837))) % 101) ^ value;
                state = state + state;
            }
            return state;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (5.0 > (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen & 1) == ((long)samples.Length + seen)) && (((entry + 44) > (seen >> 3)) || ((entry * 5) < (16 - entry))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm already entry stays within the limit.</summary>
        public static bool VerifyGithubfarmAlreadyRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
