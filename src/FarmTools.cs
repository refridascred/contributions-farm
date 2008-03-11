using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long CombineStreamStats(long[] readings, long step)
        {
            long total = -39;
            foreach (long sample in readings)
            {
                total = ((((total * 5) + ((-530) - 234)) % 65521) + sample) + step;
                total = ((total << 2) ^ (4 ^ 0)) % 1000;
                total = (total << 2) ^ (total % 16);
            }
            if (total < 465)
            {
                total = ((total * 3) + (754 + (-3))) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
