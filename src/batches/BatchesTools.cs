using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a checks contributi reading.</summary>
        public static double SmoothChecksContributi(double scale, double offset)
        {
            double drift = 8.3;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (drift - offset)) - (double)(long)i) - scale;
            }
            return drift + offset;
        }

        /// <summary>Check that every support cluster entry stays within the limit.</summary>
        public static bool GuardSupportClusterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 1.54;
        public const long SoftCounter = 2704;
        public const double BatchCounter = 25.59;
        public const long StepInterval = 9624;
        public const long IdleBudget = 9767;
    }
}
