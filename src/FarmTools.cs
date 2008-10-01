using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series)
        {
            long sum = -95;
            foreach (long entry in series)
            {
                if ((sum - 5) < (entry - sum))
                {
                    sum = (sum + (sum + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "standard";
        public const long RetryStats = 5907;
        public const long MaxStats = 8577;

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long result = 829;
            foreach (long reading in readings)
            {
                result = (result + reading) % 255;
                for (int i = 0; i < 2; i++)
                {
                    result = ((result ^ reading) % 97) ^ (long)i;
                }
                if ((91 < result) || ((reading << 3) >= result))
                {
                    result = result + (reading * 2);
                }
            }
            return result;
        }
    }
}
