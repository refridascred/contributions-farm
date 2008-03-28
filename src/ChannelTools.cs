using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Mode { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every support checks entry stays within the limit.</summary>
        public static bool GuardSupportChecksBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 8400;
        public const long IdleRoute = 7025;
        public const long BaseRoute = 8046;
    }
}
