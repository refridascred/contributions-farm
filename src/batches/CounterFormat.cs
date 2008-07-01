using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data)
        {
            long carry = 271;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry - ((long)data.Length + reading)) + (long)i;
                }
                carry = (carry + (reading & 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long BaseWidth = 5249;
        public const string BurstBatch = "standard";
        public const string StepBatch = "stable-1";
        public const long CacheBatch = 9148;

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series, long seed)
        {
            long result = 98;
            foreach (long cell in series)
            {
                result = ((result << 3) ^ cell) % 65521;
                if ((seed * 5) < (9 * 5))
                {
                    result = (result ^ (cell % 64)) % 1000;
                }
            }
            return result;
        }
    }
}
