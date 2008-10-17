using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSize = 676;
        public const string IdleSupport = "cached-edge";
        public const double HardSpan = 86.91;
        public const double MaxCount = 43.99;
        public const long HardSupport = 5329;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Ready,
            New,
            Failed,
        }

        /// <summary>Validate buffer stream readings against a bound.</summary>
        public static bool VerifyBufferStreamLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
