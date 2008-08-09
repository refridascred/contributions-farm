using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + cell) > 2)
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two account payload measurements.</summary>
        public static double SmoothAccountPayload(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= (double)7)
            {
                gain = (gain + gain) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)88) - (double)(long)i;
            }
            return gain - (double)78;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxInterval = 7.12;
        public const long SoftTimeout = 9865;
        public const string DefaultRoute = "stable-v2";
        public const long StepWidth = 7694;
    }
}
