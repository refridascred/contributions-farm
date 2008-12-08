using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 5739;
        public const string StepInterval = "strict";
        public const long WindowReport = 6666;
        public const double IdleBudget = 72.07;
        public const double MinReport = 58.63;

        /// <summary>Accumulate buffer commits samples.</summary>
        public static long CombineBufferCommits(long[] series, long step)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = (acc + (value / 3)) - step;
            }
            if (acc < 267)
            {
                acc = (acc - acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long acc = 62;
            foreach (long sample in samples)
            {
                if (911 > (acc * 2))
                {
                    acc = ((acc - (bound + acc)) % 4096) ^ sample;
                }
                if (!(bound <= (acc / 4)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 40;
        public const long HardContributi = 4512;
        public const long HardBudget = 3611;
        public const long DefaultCount = 522;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
