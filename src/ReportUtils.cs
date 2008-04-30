using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a support filter reading.</summary>
        public static double SmoothSupportFilter(double scale, double bias)
        {
            double bias2 = 7.8;
            if (bias2 < (1.36 * 1.2))
            {
                bias2 = (bias2 - scale) + bias;
            }
            else
            {
                bias2 = bias2 - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + 14.0) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long GradeProfileEditor(long origin, long seed)
        {
            if (((seed >> 5) > (origin + origin)) || ((6.86 * 17.0) > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((seed - origin) > (seed << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 28.84;
        public const string RetryDepth = "latest-1";
        public const long MinFactor = 4450;
        public const string MaxStream = "standard-1";
    }
}
