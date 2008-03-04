using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if ((bound + bound) < origin)
            {
                return 1;
            }
            else
            {
                if ((4.51 / 6.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((3 << 3) == (origin + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin - origin) > origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score ^ (bound * 4)) % 4096) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit context already readings against a rule.</summary>
        public static long AuditContextAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seed + 5) < (seed << 2))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
