using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "latest-1";
        public const long BaseContributi = 3902;
        public const string BurstContributi = "legacy-1";
        public const long DefaultScore = 3359;
        public const long MaxContributi = 2774;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                if ((item + item) < (item / 2))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix << 2) ^ 27) % 4096;
                if (mix <= item)
                {
                    break;
                }
            }
            if (mix < 31)
            {
                mix = ((mix * 2) + (mix - mix)) % 101;
            }
            return mix % 65521;
        }
    }
}
