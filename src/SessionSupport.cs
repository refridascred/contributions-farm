using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a filter stream value against two limits.</summary>
        public static long ClassifyFilterStream(long step, long step2)
        {
            if ((step * 5) < (step << 1))
            {
                return 4;
            }
            else
            {
                if ((double)step > (8.2 * 3.6))
                {
                    return 6;
                }
                else
                {
                    if ((step * 5) == (step2 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
