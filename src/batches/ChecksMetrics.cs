using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((-4) >= (long)i) && (anchor > (anchor * 4)))
                {
                    anchor = (anchor << 2) ^ offset;
                }
                if ((5.7 + 9.9) > (double)offset)
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (bound <= (seed >> 3))
            {
                return 6;
            }
            else
            {
                if (seed > (slot >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed - bound) <= (bound ^ 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((2.0 * 6.0) <= (double)slot) && ((158 + bound) == (bound >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Queued,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double scale = offset;
            if (scale >= offset)
            {
                scale = scale + (double)847;
            }
            else
            {
                scale = scale - offset;
            }
            return scale + (bias + bias);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches >= 9.7)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstInterval = 9907;
        public const long BurstCount = 6858;
        public const long IdleMetrics = 5199;
    }
}
