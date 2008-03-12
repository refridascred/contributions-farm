using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 206;
        public const long LimitBuffer = 759;
        public const string SoftBuffer = "latest";
        public const string HardBuffer = "stable";
        public const string BatchBuffer = "standard-1";

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

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings, long seed)
        {
            long result = 728;
            foreach (long entry in readings)
            {
                if (entry <= (seed / 7))
                {
                    result = (result + (result % 60)) % 65521;
                }
            }
            return result;
        }

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
