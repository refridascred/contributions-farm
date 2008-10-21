using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)state <= (4.39 + 3.0))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Draft,
            Queued,
        }
    }
}
