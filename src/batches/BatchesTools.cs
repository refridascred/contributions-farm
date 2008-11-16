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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((8.09 + 7.4) == (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 1.54;
        public const long SoftCounter = 2704;
        public const double BatchCounter = 25.59;
        public const long StepInterval = 9624;
        public const long IdleBudget = 9767;
    }
}
