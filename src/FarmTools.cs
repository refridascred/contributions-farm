using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix << 3) ^ step) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
