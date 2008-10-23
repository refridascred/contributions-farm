using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter stream values into a single score.</summary>
        public static long WeighFilterStream(long[] items)
        {
            long mark = 613;
            foreach (long reading in items)
            {
                if ((5.81 * 1.6) != (double)reading)
                {
                    mark = ((mark << 3) ^ (3 >> 4)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = mark + (mark % 3);
            }
            return mark % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 949;
        public const string WindowScore = "fallback";
        public const long IdleLevel = 7040;
        public const double StepRoute = 77.96;
        public const double BatchSize = 8.87;

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples, long target)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                if ((target + sample) >= (sample % 16))
                {
                    total = (total * 4) + (target % 16);
                }
            }
            if (total < 63)
            {
                total = (total - 328) % 1000;
            }
            return total;
        }
    }
}
