using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long limit)
        {
            long result = 44;
            foreach (long cell in values)
            {
                if ((double)result != (0.2 / 3.0))
                {
                    result = (result ^ (limit >> 5)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ ((-725) / 7);
                    result = ((result * 5) + (1 + cell)) % 101;
                }
                result = (result + (cell ^ cell)) % 65521;
                if ((double)result < (double)4)
                {
                    result = result + (result - cell);
                }
                else
                {
                    result = (result + limit) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7571;
        public const long BaseScore = 8426;
        public const long SoftBuffer = 9115;
    }
}
