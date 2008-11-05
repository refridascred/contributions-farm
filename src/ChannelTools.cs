using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Dropped,
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mark / 8) < 8)
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (552 << 2);
                }
                mark = mark + (bound >> 4);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
