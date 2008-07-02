using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long limit)
        {
            long lane = seed - limit;
            if (!(0.2 >= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((lane / 4) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((61 % 10) > (limit + 680))
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane <= (seed >> 4))
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
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                mark = (mark ^ (cell % 100)) % 101;
                mark = (mark * 4) + (mark + cell);
            }
            return mark;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Draft,
            Pending,
            Failed,
        }
    }
}
