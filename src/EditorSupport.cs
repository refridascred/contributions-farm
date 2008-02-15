using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double load = gain;
            return (load + (gain - load)) + span;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 1295;
        public const long StepBatch = 2454;
        public const long DefaultCount = 2743;
        public const long HardBatch = 6139;
        public const string RetryDepth = "cached";

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series, long floor)
        {
            long score = 9;
            foreach (long value in series)
            {
                score = (score + (6 + value)) % 101;
                score = score ^ (score + floor);
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Failed,
            Done,
        }
    }
}
