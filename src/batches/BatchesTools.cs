using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                long gap = (anchor ^ anchor) + origin;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor << 3) ^ (gap - gap)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total + 887;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
