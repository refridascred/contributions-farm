using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double load = offset;
            return (load - (double)8) + ratio;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
