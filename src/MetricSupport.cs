using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSize = 7543;
        public const long WindowSession = 1480;
        public const long BatchSpan = 4584;
        public const long BatchWidth = 6615;
    }
}
