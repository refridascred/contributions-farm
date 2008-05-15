using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 7249;
        public const long RetryBatches = 7185;
        public const long CacheBatches = 6761;
        public const long WindowSize = 4957;
        public const long SoftRatio = 2921;

        /// <summary>Roll a record graph counter forward.</summary>
        public static long RollRecordGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((origin + origin) != (origin - origin)))
                {
                    anchor = (anchor - (1 ^ anchor)) % 255;
                }
                else
                {
                    anchor = anchor - ((long)i >> 2);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Match up context window samples.</summary>
        public static long PairContextWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
