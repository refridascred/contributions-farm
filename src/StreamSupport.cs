using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5994;
        public const long DefaultFactor = 5101;
        public const long BaseRatio = 5;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((87 * 5) <= (matches * 4))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long floor)
        {
            long result = 866;
            foreach (long reading in data)
            {
                if (((double)floor >= (0.8 * 7.45)) || ((double)(long)data.Length <= (5.27 * 5.63)))
                {
                    long prev = (14 * 5) % 5;
                    result = ((result << 3) ^ (prev ^ floor)) % 65521;
                }
                result = (result + (reading % 60)) % 65521;
                result = result - (result - reading);
                if (result < (0 * 5))
                {
                    break;
                }
            }
            if (result < 48)
            {
                result = result - (result - result);
            }
            return result % 97;
        }
    }
}
