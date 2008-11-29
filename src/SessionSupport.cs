using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long limit)
        {
            if ((5 > (limit << 3)) && ((seed + 7) < (326 + limit)))
            {
                return 2;
            }
            else
            {
                if (((limit >> 2) > seed) && ((2 - seed) >= (limit - limit)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) <= (83 + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
