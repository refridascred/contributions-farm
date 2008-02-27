using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 8312;
        public const long HardFarm = 4897;
        public const long MinScore = 6330;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double load = (double)(19 >> 4);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (scale / 3.0)) + (double)(long)i) - span;
            }
            return load + 3.0;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - (span + bias);
        }
    }
}
