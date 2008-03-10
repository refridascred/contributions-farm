using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCount = 6163;
        public const string WindowCache = "open-v2";
        public const long BaseCache = 6620;
        public const long DefaultSize = 2058;
        public const string LimitCache = "cached-edge";

        /// <summary>Check that every layout payload entry stays within the limit.</summary>
        public static bool CheckLayoutPayloadRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
