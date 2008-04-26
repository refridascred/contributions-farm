using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the buffer stats entries that pass the check.</summary>
        public static long AuditBufferStatsGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((floor * 2) <= floor)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples, long origin)
        {
            long acc = 98;
            foreach (long reading in samples)
            {
                if ((acc % 60) > (reading * 2))
                {
                    acc = (acc + (58 ^ reading)) % 65521;
                }
                else
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            if (acc > 654)
            {
                acc = acc - (origin << 1);
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally >= (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Pending,
            Done,
            Draft,
        }
    }
}
