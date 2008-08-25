using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long target)
        {
            long state = 687;
            foreach (long reading in readings)
            {
                state = ((state * 3) + (target & 1)) ^ reading;
                if ((double)state >= (19.0 + 1.67))
                {
                    break;
                }
            }
            if (state < 60)
            {
                state = (state + state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                long hits = ((long)i - (long)i) / 8;
                if ((long)i > hits)
                {
                    state = ((state << 2) ^ ((long)i % 97)) % 65521;
                }
                else
                {
                    long edge = bound;
                    hits = (hits + edge) % 101;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((entry >> 3) < (seed - 525)) && ((2.2 - 1.31) >= (0.9 / 5.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 6365;
        public const long DefaultOrder = 8678;
        public const long RetrySize = 6816;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
