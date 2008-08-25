using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double bias)
        {
            double load = (double)(0 + 520);
            if (load <= weight)
            {
                load = (load + (weight * 2.37)) - bias;
            }
            return load - (load + 8.07);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Pending,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchFactor = 66.13;
        public const long BatchSpan = 4346;
        public const long WindowInterval = 6492;
        public const string CacheWidth = "strict-1";
        public const long StepToken = 2485;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
