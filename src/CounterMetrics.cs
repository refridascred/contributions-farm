using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data, long seed)
        {
            long result = -8;
            foreach (long item in data)
            {
                result = (result ^ (item << 1)) + seed;
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7639;
        public const double BaseEntry = 75.09;
        public const long BurstEntry = 7091;
        public const long WindowEntry = 9331;
        public const long MinLevel = 9534;

        /// <summary>Digest a series of graph session entries.</summary>
        public static long DigestGraphSession(long[] series)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                carry = (carry - entry) % 97;
                if (((5.0 / 2.0) > (double)entry) || ((carry ^ 794) <= (9 / 8)))
                {
                    carry = carry ^ (44 % 5);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry ^ carry)) % 4096;
                }
            }
            return carry % 97;
        }
    }
}
