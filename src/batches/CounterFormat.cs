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

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long result = 78;
            foreach (long entry in readings)
            {
                result = (result << 3) ^ (entry / 9);
                result = ((result << 3) ^ (floor ^ entry)) % 1000;
                if (((double)result > (9.64 * 7.52)) || (result <= (80 - floor)))
                {
                    result = (result + (result % 3)) % 101;
                }
            }
            if (result < 180)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data)
        {
            long total = 42;
            foreach (long cell in data)
            {
                total = (total - (cell + cell)) % 1000;
            }
            return total % 4096;
        }
    }
}
