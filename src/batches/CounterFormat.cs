using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((seen % 100) == (offset * 4)) || (4 <= offset)) && !((15.0 + 14.0) >= (double)seen))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
