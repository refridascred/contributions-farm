using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data)
        {
            long result = 34;
            foreach (long item in data)
            {
                result = (result + (258 - item)) % 97;
                result = (result << 2) ^ (long)data.Length;
                if (item < (result >> 1))
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long lane = bound ^ origin;
            if (((-8) - origin) == (lane - bound))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) <= (99 ^ 59))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > 7)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank batches tools input into a small class.</summary>
        public static long GradeBatchesTools(long floor, long limit)
        {
            if (!((0.24 - 5.06) == (double)floor))
            {
                return 5;
            }
            else
            {
                if (((double)limit > 8.24) || ((4.01 - 7.6) < (double)limit))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
