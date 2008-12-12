using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long floor)
        {
            long cur = seed - floor;
            if (floor < (cur >> 4))
            {
                return 1;
            }
            else
            {
                if ((3.95 - 11.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((cur / 9) > (0 % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 2) ^ (long)i) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)0 >= (double)(long)items.Length))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long MeasureClusterOrderHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (limit + (long)data.Length))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
