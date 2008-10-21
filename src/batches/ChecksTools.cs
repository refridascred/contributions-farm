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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor * 4) + (7 + anchor);
                if (target >= (target / 8))
                {
                    anchor = anchor - (anchor >> 4);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
