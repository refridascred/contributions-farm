using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long target, long bound)
        {
            if (target > (target + bound))
            {
                return 3;
            }
            else
            {
                if (bound >= (bound + 12))
                {
                    return 1;
                }
                else
                {
                    if (!(bound >= (target & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context stream entries that pass the check.</summary>
        public static long CountContextStreamOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)(long)series.Length <= (2.3 - 1.67)))
                {
                    count = ((count + 1) - cell) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate cache notes readings against a bound.</summary>
        public static bool ValidateCacheNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
