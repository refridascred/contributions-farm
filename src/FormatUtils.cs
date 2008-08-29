using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long SeekBatchesGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (count / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long TallyMetricsOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally ^ tally) != (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
