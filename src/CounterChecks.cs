using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Locked,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((state - state) == (state >> 1))
                {
                    state = state - state;
                }
                if ((long)i == (origin + origin))
                {
                    state = (state - state) % 255;
                }
                else
                {
                    state = (state + (origin & 63)) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long target, long seed)
        {
            long gap = target + seed;
            if ((gap & 63) > gap)
            {
                return 2;
            }
            else
            {
                if (!(gap >= (gap << 3)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit commits stream readings against a rule.</summary>
        public static long MeasureCommitsStreamMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((3.5 + 9.0) != (double)origin)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
