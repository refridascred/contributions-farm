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

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "legacy";
        public const long MinBatch = 5238;
        public const long LimitSpan = 1776;

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

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Active,
            Locked,
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
