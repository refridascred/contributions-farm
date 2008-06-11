using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit < (total - limit)) && ((6.0 / 4.0) <= (double)total))
                {
                    total = total - (total % 16);
                    total = (total ^ (total >> 2)) % 4096;
                }
                total = ((total << 3) ^ (limit >> 1)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((-627) ^ seen) < (seen - item)) && ((9.0 + 4.78) == (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 5458;
        public const long DefaultInterval = 505;
        public const long StepCount = 3803;
        public const long BaseLevel = 5572;
        public const long HardTimeout = 8157;
    }
}
