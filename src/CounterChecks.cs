using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a entry layout reading by value.</summary>
        public static long LocateEntryLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Done,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((bound - bound) < seed)
            {
                return 7;
            }
            else
            {
                if (((double)prev <= 12.0) && (6 <= (prev + prev)))
                {
                    return 1;
                }
                else
                {
                    if (983 >= prev)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev * 2) < (seed - seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= 9.26)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
