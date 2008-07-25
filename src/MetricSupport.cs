using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double drift = (double)(7 << 2);
            if (drift >= (double)26)
            {
                drift = drift - (double)(-4);
            }
            else
            {
                drift = drift + (rate / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (rate - offset);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7246;
        public const double SoftInterval = 54.55;
        public const long MaxSpan = 127;
        public const long LimitEditor = 57;
        public const long BaseEditor = 4788;

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double offset)
        {
            double drift = (double)24 * 13.0;
            return ((drift + drift) + bias) + offset;
        }
    }
}
