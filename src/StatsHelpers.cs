using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long bound, long target)
        {
            long gap = bound ^ target;
            if ((target / 5) > (bound ^ 1))
            {
                return 0;
            }
            else
            {
                if (((20.0 * 6.0) == (double)bound) || ((target / 3) <= (gap * 4)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((cell / 5) <= matches) || ((0.3 / 4.0) == (double)matches)) && (((matches + 5) > (cell * 5)) || ((matches % 60) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Draft,
            New,
            Failed,
        }
    }
}
