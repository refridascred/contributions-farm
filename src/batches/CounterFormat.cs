using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels)
        {
            long mark = 891;
            foreach (long reading in levels)
            {
                if (((-282) - reading) < (mark + reading))
                {
                    mark = (mark + reading) % 4096;
                }
                if (mark <= (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
