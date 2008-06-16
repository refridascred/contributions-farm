using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Stale,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Pending,
            Active,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                long hits = (seed - seed) / 8;
                if ((hits > (seed - 112)) && ((score << 1) >= (hits ^ (long)i)))
                {
                    hits = (hits ^ ((long)i / 7)) % 65521;
                    score = (score + seed) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseWidth = "local";
        public const long WindowCommand = 7736;
        public const long BurstCommand = 210;
        public const string CacheCommand = "primary-1";

        /// <summary>Rank support contributi input into a small class.</summary>
        public static long SortSupportContributi(long origin, long target)
        {
            long prev = origin + target;
            if ((652 & 1) > (prev >> 2))
            {
                return 2;
            }
            else
            {
                if (((prev % 5) == (prev * 4)) || ((double)origin > (1.68 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (((prev % 60) != (origin ^ origin)) || ((double)prev < (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)prev <= (4.0 - 11.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank graph record input into a small class.</summary>
        public static long ClassifyGraphRecord(long floor, long step)
        {
            if ((step * 5) != (4 / 2))
            {
                return 3;
            }
            else
            {
                if ((7.04 + 2.0) <= (double)floor)
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
}
