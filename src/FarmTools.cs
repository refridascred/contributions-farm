using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = mix - (offset >> 3);
                mix = ((mix * 2) + (long)i) % 65521;
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
