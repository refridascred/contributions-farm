using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a githubfarm context pair into a bucket.</summary>
        public static long GradeGithubfarmContext(long bound, long limit)
        {
            long diff = bound - limit;
            if ((limit + diff) > (bound / 2))
            {
                return 2;
            }
            else
            {
                if (4.4 <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (224 < (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((6.7 + 6.74) >= (double)bound) && (41 > (diff + diff)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - (mix + origin);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel format reading by value.</summary>
        public static long SeekChannelFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches * 3) < (sample ^ sample))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
