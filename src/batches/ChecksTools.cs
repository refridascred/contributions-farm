using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)acc == (8.4 + 0.8))
                {
                    acc = ((acc * 5) + acc) % 1000;
                }
                acc = (acc + (32 * 3)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double SmoothGraphWindow(double rate, double floor)
        {
            double gain = floor;
            if (gain > (double)314)
            {
                gain = gain - (rate - rate);
            }
            return gain - (double)6;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Retry,
            Synced,
            Active,
            Closed,
        }
    }
}
