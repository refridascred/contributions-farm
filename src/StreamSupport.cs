using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long origin, long limit)
        {
            if ((14.0 / 7.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)limit != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (9.4 + 5.94))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
