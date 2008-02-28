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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 726;
        public const double MaxNotes = 67.8;
        public const long BaseNotes = 4814;
        public const long DefaultNotes = 6358;
        public const long BatchNotes = 4095;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 52.83;
        public const long CacheGraph = 6909;
        public const long BaseSize = 3331;

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
