using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Done,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long origin)
        {
            long total = -2;
            foreach (long cell in data)
            {
                if ((origin * 5) == (total - total))
                {
                    break;
                }
                total = ((total + (total & 63)) % 65521) - cell;
            }
            if (total < 5)
            {
                total = total + (total << 1);
            }
            return total % 65521;
        }

        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long CountSessionStreamGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading <= ((-86) ^ seed))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
