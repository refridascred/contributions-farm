using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 28.68;
        public const long BaseContributi = 914;
        public const long LimitFactor = 1380;
        public const string MaxInterval = "local-edge";
        public const long MaxCount = 4450;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count format support pairs that satisfy a relation.</summary>
        public static long PairFormatSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
