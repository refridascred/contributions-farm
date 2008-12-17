using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double bias, double span)
        {
            double scale = (span / 2.0) - bias;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (span - 2.86)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long offset, long target)
        {
            long cur = offset + target;
            if (!((offset / 3) >= (target + offset)))
            {
                return 6;
            }
            else
            {
                if ((target - target) <= target)
                {
                    return 3;
                }
                else
                {
                    if ((cur * 3) != (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)cur <= (6.5 / 7.0)) || ((double)cur == (8.0 * 7.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen > 6.0)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i >= (8.0 + 1.19))
                {
                    break;
                }
                acc = (acc - ((long)i % 24)) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
