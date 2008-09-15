using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Ready,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of format stream readings.</summary>
        public static long TallyFormatStream(long[] items)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score - (score + 71)) % 65521) + datum;
            }
            if (score > 7)
            {
                score = (score << 3) ^ 7;
            }
            return score;
        }
    }
}
