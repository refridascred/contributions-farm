using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count layout commits pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Pending,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
