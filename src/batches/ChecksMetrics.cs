using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long SeriesGithubfarmRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long mark = 59;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ mark) % 4096) + cell;
            }
            return mark % 4096;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Size { get; set; }
            public bool Count { get; set; }
            public bool Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
