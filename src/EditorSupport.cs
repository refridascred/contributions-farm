using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long step, long bound)
        {
            long diff = step + bound;
            if ((253 * 4) > (step >> 1))
            {
                return 0;
            }
            else
            {
                if (((double)diff != (4.7 / 3.0)) && ((diff * 5) <= (777 + 4)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step > (0.2 - 2.95))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (5.99 * 5.4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long origin)
        {
            if ((origin - origin) > (origin % 97))
            {
                return 1;
            }
            else
            {
                if (((origin - 152) <= (origin + seed)) || ((origin << 2) > 86))
                {
                    return 3;
                }
                else
                {
                    if (seed <= (seed * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >= (origin << 3)) || ((seed % 3) == (origin - seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
