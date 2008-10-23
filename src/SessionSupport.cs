using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.8 - 0.1) < (double)value)
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
