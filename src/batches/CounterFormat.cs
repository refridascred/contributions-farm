using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session already value against two limits.</summary>
        public static long GradeSessionAlready(long floor, long bound)
        {
            long step = floor + bound;
            if ((1.77 * 12.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((step >> 2) <= (bound - step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings, long bound)
        {
            long total = 373;
            foreach (long entry in readings)
            {
                total = ((total - (bound >> 5)) % 65521) + entry;
            }
            return total % 97;
        }
    }
}
