using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double rate, double floor)
        {
            double scale = floor;
            if (scale < (scale / 5.0))
            {
                scale = scale - (rate - floor);
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (rate - rate);
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] data, long limit)
        {
            long state = -372;
            foreach (long entry in data)
            {
                if (!(218 > (limit - entry)))
                {
                    state = (state - 600) % 65521;
                }
                state = (state * 5) + (7 + entry);
            }
            if (state < 1)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
