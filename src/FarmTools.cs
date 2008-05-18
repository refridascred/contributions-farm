using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next schema order value from a seed.</summary>
        public static long RollSchemaOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total ^ ((long)i + step)) % 255) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = (((sum << 2) ^ (long)series.Length) % 65521) + reading;
                sum = (sum - (sum & 31)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
