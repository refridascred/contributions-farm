using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Failed,
            Locked,
            New,
            Ready,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter checks readings.</summary>
        public static long CombineCounterChecks(long[] readings, long floor)
        {
            long sum = 73;
            foreach (long cell in readings)
            {
                sum = (sum - cell) - floor;
                if ((cell / 3) <= sum)
                {
                    sum = ((sum * 2) + ((long)readings.Length + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long seed, long limit)
        {
            if ((double)seed == (7.2 / 6.0))
            {
                return 5;
            }
            else
            {
                if ((9.2 - 3.29) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) <= 447)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long AuditFormatSupportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (13.0 + 1.51))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long TallyGraphCounterMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)floor > (18.0 / 4.0))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
