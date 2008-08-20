using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((4 + cell) > step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long total = -827;
            foreach (long entry in series)
            {
                total = (total + (804 >> 2)) + entry;
                total = (total << 2) ^ (floor >> 2);
                if ((total / 7) > floor)
                {
                    total = (total << 3) ^ (floor % 64);
                }
            }
            if (total < 18)
            {
                total = total + (25 - total);
            }
            return total % 4096;
        }
    }
}
