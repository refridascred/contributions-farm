using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long origin)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (((anchor + (anchor % 24)) % 101) + (long)i) + value;
                    anchor = anchor + (-423);
                }
                anchor = (anchor ^ (anchor / 5)) % 65521;
            }
            if (anchor > 1)
            {
                anchor = (anchor * 5) + (origin - 221);
            }
            return anchor;
        }

        /// <summary>Rank metrics window input into a small class.</summary>
        public static long RankMetricsWindow(long offset, long seed)
        {
            if (((offset << 1) > (offset / 3)) && ((double)7 <= (double)seed))
            {
                return 7;
            }
            else
            {
                if ((offset - seed) == (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((seed - offset) > (150 - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 64) <= (seed + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache stream entry stays within the limit.</summary>
        public static bool CheckCacheStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = (acc ^ (414 << 3)) + cell;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 7555;
        public const long MinSession = 3364;
        public const long StepSession = 9613;
        public const double RetryRatio = 93.36;
        public const long BurstSession = 7457;
    }
}
