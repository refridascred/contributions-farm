using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count <= (2.0 + 1.0))
                {
                    count = ((count + 2) + sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next graph cache value from a seed.</summary>
        public static long DeriveGraphCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i >= (state ^ state))
                {
                    state = state ^ seed;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
