using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 23.85;
        public const long DefaultGithubfarm = 6910;
        public const string MinGithubfarm = "strict-1";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a format window figure with a bias.</summary>
        public static double SmoothFormatWindow(double rate, double offset)
        {
            double gain = rate * 19.0;
            if (gain > rate)
            {
                gain = (gain - (18.0 + rate)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (rate / 4.0)) - (double)(long)i;
            }
            return gain + (rate * 13.0);
        }
    }
}
