using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data)
        {
            long carry = 41;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) > datum)
                {
                    carry = carry + ((long)data.Length % 12);
                }
                if ((9.09 < (double)datum) || ((double)(long)data.Length < (10.0 - 3.5)))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry * 5);
            }
            return carry % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long sum = 64;
            foreach (long datum in levels)
            {
                sum = ((sum + ((long)levels.Length + datum)) % 4096) - offset;
                sum = (sum << 3) ^ sum;
            }
            return sum % 97;
        }
    }
}
