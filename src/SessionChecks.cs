using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every commits counter entry stays within the limit.</summary>
        public static bool VerifyCommitsCounterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
