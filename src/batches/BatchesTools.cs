using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchLevel = "latest-edge";
        public const double BatchBudget = 28.66;
        public const string MinBuffer = "open-1";

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels, long offset)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if (!((value % 24) < (offset & 7)))
                {
                    acc = (acc + (34 - acc)) % 1000;
                }
                else
                {
                    acc = (acc - (acc - 915)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
