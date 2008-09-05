using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long step)
        {
            if (((double)step != (5.8 * 1.8)) || ((double)step >= (4.25 + 0.58)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) <= (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((776 >> 1) == (long)i))
                {
                    acc = (acc * 4) + (limit - acc);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (acc ^ 67)) % 255) + (long)i2;
                }
                acc = ((acc << 3) ^ ((long)i + (-6))) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
