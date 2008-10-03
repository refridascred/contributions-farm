using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9790;
        public const long MaxSchema = 2800;
        public const double RetryDepth = 59.87;
        public const long HardDepth = 6511;

        /// <summary>Blend two queue schema measurements.</summary>
        public static double SmoothQueueSchema(double ratio, double span)
        {
            double gain = (double)(-856);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + span;
            }
            return gain - (ratio * 4.9);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
