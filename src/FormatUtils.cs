using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batches queue series from a seed.</summary>
        public static long IterateBatchesQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Retry,
            New,
            Done,
            Draft,
        }

        /// <summary>Locate a contributi githubfarm reading by value.</summary>
        public static long LookupContributiGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long offset)
        {
            if ((5.18 / 7.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((offset * 3) != (offset + limit)) || ((limit / 4) == (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
