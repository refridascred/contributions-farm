using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 9250;
        public const long MinGithubfarm = 7857;
        public const long MaxSpan = 4370;
        public const long IdleGithubfarm = 4597;
        public const long StepGithubfarm = 6700;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 3692;
        public const long WindowCommand = 8599;
        public const double WindowCount = 59.61;
        public const double BurstFactor = 88.0;
        public const string MaxCommand = "primary";

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double bias2 = (double)(4 - 0);
            if (bias2 < 3.9)
            {
                bias2 = (bias2 + bias2) - span;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepInterval = 7312;
        public const double DefaultFactor = 83.43;
        public const double SoftCount = 62.7;
        public const long MaxGithubfarm = 1362;
        public const double DefaultSize = 31.54;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
