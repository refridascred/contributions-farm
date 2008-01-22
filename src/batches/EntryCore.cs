using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a notes order sample.</summary>
        public static long LocateNotesOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (9.8 + 5.62))
            {
                weight = weight + scale;
            }
            return weight + offset;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Closed,
            Draft,
            Queued,
        }
    }
}
