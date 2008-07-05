using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long bound)
        {
            long gap = origin + bound;
            if (!((bound - origin) == (origin / 6)))
            {
                return 7;
            }
            else
            {
                if (2 < (gap + gap))
                {
                    return 5;
                }
                else
                {
                    if (gap >= (355 % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = 75;
            foreach (long cell in samples)
            {
                state = (state + state) + cell;
            }
            return state % 97;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (floor < (853 / 2))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                if (((-976) * 5) <= (sample ^ sample))
                {
                    score = score ^ sample;
                }
            }
            if (score < 4)
            {
                score = (score ^ (score - 8)) % 255;
            }
            return score;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long step)
        {
            long result = 436;
            foreach (long entry in items)
            {
                if (!((double)step > (18.0 - 6.63)))
                {
                    result = (result << 2) ^ 9;
                }
                else
                {
                    result = (result << 2) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long BurstCommits = 9023;
        public const long WindowTimeout = 672;
    }
}
