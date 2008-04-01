using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Queued,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long TotalTokenGithubfarm(long[] items)
        {
            long score = 1;
            foreach (long sample in items)
            {
                if (((score + score) == (score - sample)) && (score <= (sample + 270)))
                {
                    continue;
                }
                score = ((score * 5) + (sample + sample)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels)
        {
            long acc = 41;
            foreach (long entry in levels)
            {
                acc = acc - (acc - entry);
                if ((double)acc == (3.5 * 1.44))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((19 + 74) < value))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long step)
        {
            long slot = origin - step;
            if ((slot & 1) >= (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (7.96 - 3.6))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin > (7.9 / 7.0))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
