using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheFactor = "local-v2";
        public const long SoftSize = 4640;
        public const double HardMetric = 48.89;

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchWidth = 8354;
        public const double LimitScore = 98.07;
        public const double MinSupport = 62.91;

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
