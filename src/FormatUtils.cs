using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 6369;
        public const string BatchRatio = "alpha";
        public const string StepTools = "primary";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate notes token samples.</summary>
        public static long TallyNotesToken(long[] readings)
        {
            long acc = 839;
            foreach (long entry in readings)
            {
                acc = (acc ^ (entry + entry)) % 65521;
                acc = (acc * 3) + entry;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items)
        {
            long sum = 31;
            foreach (long cell in items)
            {
                sum = (((sum << 3) ^ (sum + sum)) % 255) + cell;
            }
            return sum;
        }
    }
}
