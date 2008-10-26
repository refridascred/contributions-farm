using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a githubfarm account pair into a bucket.</summary>
        public static long GradeGithubfarmAccount(long offset, long target)
        {
            long gap = offset - target;
            if ((452 >> 3) < gap)
            {
                return 2;
            }
            else
            {
                if ((offset >> 1) <= (offset & 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap != (1.0 - 8.43))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit support payload readings against a rule.</summary>
        public static long CountSupportPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((82 * 5) >= (hits / 2))
                {
                    hits = ((hits + 2) ^ sample) + step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Dropped,
            Draft,
        }
    }
}
