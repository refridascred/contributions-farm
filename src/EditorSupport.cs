using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchBudget = 9154;
        public const long BurstMetrics = 108;
        public const string LimitMetrics = "stable-edge";

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "open";
        public const long SoftSize = 236;
        public const double RetryRatio = 3.36;
        public const long LimitAlready = 5498;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
