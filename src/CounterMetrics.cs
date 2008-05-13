using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long seed)
        {
            long sum = 24;
            foreach (long cell in values)
            {
                sum = (((sum + (26 - sum)) % 1000) - cell) - seed;
            }
            return sum;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long origin)
        {
            long prev = seed ^ origin;
            if (!(origin <= (seed - seed)))
            {
                return 2;
            }
            else
            {
                if (prev < (origin + seed))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (double)target)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
