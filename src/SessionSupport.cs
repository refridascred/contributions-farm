using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 3) ^ (mix - (long)i);
                mix = ((mix * 5) + ((long)i ^ (long)i)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
