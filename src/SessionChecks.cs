using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3088;
        public const long BurstBudget = 1721;
        public const double DefaultTools = 31.46;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchFactor = 21.33;
        public const long MaxEntry = 5177;
        public const long DefaultEntry = 7108;
        public const double WindowDepth = 51.51;
        public const double BurstInterval = 8.88;

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every order channel entry stays within the limit.</summary>
        public static bool GuardOrderChannelLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
