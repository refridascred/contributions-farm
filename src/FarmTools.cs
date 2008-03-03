using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + ((long)i * 5);
                result = (result * 5) + (863 + result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long origin)
        {
            long acc = 99;
            foreach (long cell in values)
            {
                acc = ((acc + 34) % 4096) - cell;
                if ((double)(-7) <= (double)acc)
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((origin % 10) >= (acc >> 1))
                {
                    break;
                }
            }
            if (acc > 704)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
