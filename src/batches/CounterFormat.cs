using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a graph cluster value against two limits.</summary>
        public static long SortGraphCluster(long step, long bound)
        {
            if ((926 ^ bound) != (bound + 91))
            {
                return 1;
            }
            else
            {
                if ((57 << 3) != (step & 15))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Active,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - origin) % 101) ^ (long)i2;
                    total = (total << 2) ^ 784;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
