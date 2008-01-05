using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9392;
        public const long BatchChecks = 7156;
        public const long StepChecks = 3472;

        /// <summary>Define record limits and defaults.</summary>
        public const long MinWidth = 9718;
        public const string LimitRecord = "fallback-edge";
        public const double BatchRecord = 9.1;
        public const long DefaultRecord = 2367;

        /// <summary>Roll a queue batches counter forward.</summary>
        public static long IterateQueueBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load - scale;
            }
            return load + offset;
        }
    }
}
