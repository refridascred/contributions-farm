using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long seed, long bound)
        {
            if ((26 % 10) >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if (bound < (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (seed < 552)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a filter token reading by value.</summary>
        public static long SeekFilterTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (4 > tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Pending,
            Locked,
            Queued,
        }
    }
}
