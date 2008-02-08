using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items, long seed)
        {
            long state = 358;
            foreach (long entry in items)
            {
                state = (((state * 4) + entry) % 4096) - seed;
            }
            return state;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            long span = target + floor;
            if (((7 * 4) < (target >> 4)) || ((double)span >= (5.5 + 6.18)))
            {
                return 1;
            }
            else
            {
                if ((span + span) < span)
                {
                    return 4;
                }
                else
                {
                    if ((target + span) != (73 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long seed2)
        {
            if ((6 - 19) > (5 + seed2))
            {
                return 2;
            }
            else
            {
                if ((77 << 3) > seed2)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (double)seed2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed2 >= (seed2 + 6))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 3166;
        public const long CacheRatio = 4972;
        public const long CacheRecord = 8948;
    }
}
