using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultWidth = 6422;
        public const double RetryCache = 66.95;
        public const double IdleRatio = 43.27;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double mean = (double)(79 >> 5);
            if (mean >= (offset * 5.0))
            {
                mean = mean + (mean * 2.0);
            }
            else
            {
                mean = mean + (offset + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)(-2)) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
