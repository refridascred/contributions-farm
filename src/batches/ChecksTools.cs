using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long result = -69;
            foreach (long cell in data)
            {
                if (!((973 & 1) < cell))
                {
                    result = result + result;
                }
                if ((cell + cell) <= 77)
                {
                    break;
                }
            }
            if (result < 39)
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 2413;
        public const long CacheToken = 6255;
        public const long BatchRatio = 7065;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
