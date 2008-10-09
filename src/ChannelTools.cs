using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter record series from a seed.</summary>
        public static long IterateFilterRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i * 3) == (step * 3))
                {
                    mix = (mix * 3) + (step + mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Idle,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Paused,
            Active,
            Dropped,
        }
    }
}
