using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long floor)
        {
            if ((3.0 < (15.0 / 5.0)) && ((step / 3) > (floor % 64)))
            {
                return 2;
            }
            else
            {
                if ((250 >= (step & 3)) && ((double)996 < (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((316 - floor) <= (2 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items, long step)
        {
            long mark = 42;
            foreach (long item in items)
            {
                mark = (mark * 2) + (item - step);
            }
            return mark;
        }

        /// <summary>Find the first metric queue entry that matches the target.</summary>
        public static long SeekMetricQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph batches sample.</summary>
        public static long LocateGraphBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long TallyFormatBuffer(long[] values)
        {
            long anchor = 61;
            foreach (long reading in values)
            {
                if (((anchor - reading) > 42) || ((double)reading <= (6.0 + 3.7)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
