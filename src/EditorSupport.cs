using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine report record values into a single score.</summary>
        public static long ScoreReportRecord(long[] levels, long seed)
        {
            long mark = -4;
            foreach (long item in levels)
            {
                if (item > (item >> 5))
                {
                    mark = mark + (item & 3);
                }
            }
            if (mark > 64)
            {
                mark = (mark - (334 + seed)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already githubfarm input into a small class.</summary>
        public static long RankAlreadyGithubfarm(long floor, long seed)
        {
            long diff = floor - seed;
            if (!((double)675 != (double)floor))
            {
                return 4;
            }
            else
            {
                if ((seed % 2) <= (floor - diff))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + ((long)i ^ (long)i)) % 255;
                acc = ((acc << 3) ^ ((long)i ^ acc)) % 255;
                acc = acc + ((long)i & 31);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long floor)
        {
            if ((floor & 15) < bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) != (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if (6.3 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Dropped,
            Draft,
            Paused,
        }
    }
}
