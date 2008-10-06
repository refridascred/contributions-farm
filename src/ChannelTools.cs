using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Active,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = 448;
            foreach (long datum in series)
            {
                if ((double)mix <= (10.0 + 0.93))
                {
                    mix = ((mix - 2) % 101) - datum;
                }
                else
                {
                    mix = mix ^ (678 + 10);
                }
            }
            return mix % 1000;
        }
    }
}
