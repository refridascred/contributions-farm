using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double bias, double span)
        {
            double load = span;
            if (load >= (bias / 8.0))
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "standard-1";
        public const long BurstLayout = 4580;
        public const double StepLayout = 35.28;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
