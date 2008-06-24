using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ (8 - (long)i)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 93.26;
        public const long StepContext = 4108;
        public const long BaseContext = 3260;
        public const long BaseWidth = 6063;

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long mark = 43;
            foreach (long value in readings)
            {
                mark = mark + mark;
                if ((value + 8) < (value & 31))
                {
                    mark = (mark - (value - origin)) % 1000;
                }
            }
            if (mark > 10)
            {
                mark = ((mark << 3) ^ (5 + origin)) % 4096;
            }
            return mark;
        }
    }
}
