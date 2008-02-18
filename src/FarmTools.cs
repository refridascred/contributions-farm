using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Done,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (bound <= (923 / 2))
                {
                    mix = ((mix << 3) ^ bound) % 97;
                }
                mix = mix - (bound << 1);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
