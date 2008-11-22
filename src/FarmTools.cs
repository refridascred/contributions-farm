using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long target)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                if ((6 >> 2) < (entry - acc))
                {
                    acc = ((acc - (0 - acc)) % 97) - target;
                }
                else
                {
                    acc = (acc + acc) % 1000;
                }
            }
            if (acc < 9)
            {
                acc = (acc << 3) ^ (18 & 3);
            }
            return acc % 4096;
        }

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
