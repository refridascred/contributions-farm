using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "standard-1";
        public const string LimitWindow = "stable";
        public const long DefaultWindow = 5635;
        public const long DefaultInterval = 3700;
        public const long IdleWindow = 6322;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values, long seed)
        {
            long result = 8;
            foreach (long entry in values)
            {
                if ((131 + result) <= (entry / 6))
                {
                    result = result ^ (entry - result);
                }
                if (((871 - seed) != ((-52) & 1)) || (8 <= (entry * 3)))
                {
                    result = result + 873;
                }
            }
            if (result < 89)
            {
                result = (result * 5) + seed;
            }
            return result;
        }
    }
}
