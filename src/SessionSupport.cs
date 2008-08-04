using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitScore = 3385;
        public const long MaxDepth = 1251;
        public const string BurstProfile = "strict-1";
        public const long RetryFactor = 9956;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long bound)
        {
            long result = 97;
            foreach (long cell in levels)
            {
                result = result ^ (bound + result);
                if ((9.43 * 8.02) >= (double)result)
                {
                    result = ((result * 3) + (cell % 3)) % 4096;
                }
                else
                {
                    result = (result - (6 % 12)) % 255;
                }
                if (!((double)result > (1.0 + 0.4)))
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = (result * 5) + (bound << 2);
            }
            return result % 65521;
        }
    }
}
