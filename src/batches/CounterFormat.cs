using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 2917;
        public const string MaxReport = "cached-1";
        public const string RetryReport = "cached-edge";
        public const long MinFactor = 6343;
        public const long DefaultReport = 681;

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long floor)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if (((sample ^ floor) == (sample & 7)) || ((sample & 31) > (floor / 6)))
                {
                    result = (result << 2) ^ (floor + floor);
                }
            }
            if (result > 313)
            {
                result = ((result << 3) ^ (result / 6)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Stale,
            Done,
            Closed,
            Active,
        }
    }
}
