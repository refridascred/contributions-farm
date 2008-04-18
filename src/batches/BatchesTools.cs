using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)result < (7.1 + 17.0)) && (target >= (target + (long)i)))
                {
                    result = ((result << 2) ^ 272) % 1000;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ ((long)i % 5)) % 101) + (long)i2;
                    result = (result - (result % 97)) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every graph already entry stays within the limit.</summary>
        public static bool ValidateGraphAlreadyRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 2964;
        public const long MaxQueue = 2849;
        public const double WindowRatio = 27.27;
        public const long BatchQueue = 7526;
        public const long MinTimeout = 2283;
    }
}
