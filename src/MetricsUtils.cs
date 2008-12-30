using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            if ((double)bound >= (5.2 / 6.0))
            {
                return 1;
            }
            else
            {
                if (((bound ^ (-3)) > (floor / 2)) || ((bound + bound) != (floor / 5)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings)
        {
            long score = -85;
            foreach (long sample in readings)
            {
                if ((sample ^ sample) < (score - score))
                {
                    score = ((score * 5) + (score % 10)) % 4096;
                }
            }
            if (score < 797)
            {
                score = (score + score) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Validate cache githubfarm readings against a bound.</summary>
        public static bool VerifyCacheGithubfarmBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
