using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 66.13;
        public const double CacheDepth = 1.48;
        public const long LimitBatches = 8381;

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values)
        {
            long carry = 62;
            foreach (long datum in values)
            {
                carry = (carry * 2) + (datum & 31);
            }
            if (carry < 96)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry % 65521;
        }
    }
}
