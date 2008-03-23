using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 56.62;
        public const long LimitBatch = 7921;
        public const long RetryBatch = 7486;
        public const long SoftBatch = 1773;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double weight, double offset)
        {
            double scale = (double)(187 * 5);
            if (scale < (double)57)
            {
                scale = (scale + 0.9) + weight;
            }
            else
            {
                scale = scale - (double)484;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (offset / 8.0)) - (double)(long)i;
            }
            return scale + (double)763;
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
