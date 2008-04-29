using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long state = -34;
            foreach (long datum in series)
            {
                if (!((double)floor > 15.0))
                {
                    state = state + datum;
                }
                else
                {
                    state = (state + (datum ^ 45)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count >= 16.0)
                {
                    count = ((count + 3) + item) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long GradeProfileEditor(long origin, long seed)
        {
            if (((seed >> 5) > (origin + origin)) || ((6.86 * 17.0) > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((seed - origin) > (seed << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
