using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
