using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every batch githubfarm entry stays within the limit.</summary>
        public static bool GuardBatchGithubfarmLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long AuditFormatBatchMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) == (seed % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long score = 41;
            foreach (long sample in items)
            {
                score = ((score << 3) ^ (score << 2)) ^ sample;
                score = ((score << 3) ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double weight = (scale * 0.23) + (bias / 2.0);
            if (weight <= 4.2)
            {
                weight = weight + (double)530;
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + (scale - bias);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + 206) != (item / 3))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
