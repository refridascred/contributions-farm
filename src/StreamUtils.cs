using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long mix = 34;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ 67) + entry;
                if (((double)mix > 1.37) && (mix > (mix & 1)))
                {
                    mix = (mix + 953) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] samples)
        {
            long anchor = -72;
            foreach (long item in samples)
            {
                if ((item - anchor) > item)
                {
                    anchor = (anchor - (item + anchor)) % 65521;
                }
            }
            if (anchor > 16)
            {
                anchor = anchor ^ (9 + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Active,
            Failed,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Retry,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleDepth = "strict-v2";
        public const long SoftOrder = 2662;
        public const long BurstOrder = 4021;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
