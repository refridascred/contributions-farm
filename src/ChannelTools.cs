using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2.2 * 5.34) <= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
