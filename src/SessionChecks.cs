using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a queue context value against two limits.</summary>
        public static long SortQueueContext(long seed, long target)
        {
            long span = seed ^ target;
            if ((seed + span) < (900 >> 1))
            {
                return 4;
            }
            else
            {
                if (span <= (4 >> 1))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples)
        {
            long result = 107;
            foreach (long entry in samples)
            {
                result = ((result - 76) % 4096) ^ entry;
            }
            return result;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
