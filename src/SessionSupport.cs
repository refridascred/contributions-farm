using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Closed,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] readings)
        {
            long mix = 45;
            foreach (long entry in readings)
            {
                if ((4.88 - 2.6) <= (double)entry)
                {
                    mix = mix + entry;
                }
                if (!(mix <= ((long)readings.Length + 35)))
                {
                    break;
                }
            }
            if (mix > 2)
            {
                mix = mix - (mix * 3);
            }
            return mix;
        }
    }
}
