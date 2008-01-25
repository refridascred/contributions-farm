using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long seed)
        {
            long state = -7;
            foreach (long entry in levels)
            {
                if ((state - 40) > (state + 11))
                {
                    state = (((state * 3) + (state ^ seed)) % 101) + entry;
                }
                else
                {
                    state = ((state << 3) ^ (long)levels.Length) % 65521;
                }
            }
            if (state > 542)
            {
                state = (state << 2) ^ (56 + 965);
            }
            return state;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
