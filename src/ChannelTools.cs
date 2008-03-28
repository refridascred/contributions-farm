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

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
