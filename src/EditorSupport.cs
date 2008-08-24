using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Derive the next context stats value from a seed.</summary>
        public static long DeriveContextStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((score / 6) == (579 - limit))
                {
                    score = score - ((long)i - 78);
                    score = score - (limit << 1);
                    break;
                }
                if (limit < score)
                {
                    score = (score ^ (limit + (long)i)) % 65521;
                }
                else
                {
                    score = (score + (limit + limit)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits githubfarm entries.</summary>
        public static long FoldCommitsGithubfarm(long[] readings)
        {
            long total = 496;
            foreach (long datum in readings)
            {
                total = ((total - (total - 917)) % 97) + datum;
            }
            if (total > 936)
            {
                total = (total + (total * 4)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftWidth = 6382;
        public const double RetryBudget = 2.74;
        public const long RetryReport = 8218;
        public const string HardDepth = "strict";
        public const long BaseReport = 1040;
    }
}
