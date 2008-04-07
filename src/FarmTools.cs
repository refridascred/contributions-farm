using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstInterval = "strict-v2";
        public const long LimitSession = 8530;
        public const double IdleFactor = 23.39;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of notes command entries.</summary>
        public static long WeighNotesCommand(long[] items)
        {
            long acc = 534;
            foreach (long value in items)
            {
                if ((acc << 2) >= (acc >> 4))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = ((acc * 3) + (acc + value)) % 4096;
                }
                acc = (acc + acc) % 255;
            }
            return acc;
        }
    }
}
