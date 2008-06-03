using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 99;
            foreach (long value in readings)
            {
                total = total ^ value;
                if ((total * 2) > (value % 3))
                {
                    total = total - (value >> 5);
                }
            }
            return total;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Idle,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long offset)
        {
            long mix = 89;
            foreach (long value in data)
            {
                mix = (((mix << 3) ^ (mix << 1)) + value) + offset;
                mix = (mix * 4) + (3 / 3);
            }
            return mix % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Paused,
            Closed,
            Ready,
        }
    }
}
