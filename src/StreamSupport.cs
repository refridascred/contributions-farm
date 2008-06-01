using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine entry account values into a single score.</summary>
        public static long TotalEntryAccount(long[] levels, long limit)
        {
            long acc = 917;
            foreach (long sample in levels)
            {
                acc = (acc - acc) % 1000;
                acc = ((acc << 3) ^ (sample >> 5)) % 4096;
                if ((972 - limit) < (limit - (-7)))
                {
                    acc = (acc ^ 36) % 97;
                }
            }
            if (acc > (-2))
            {
                acc = (acc << 3) ^ (limit + acc);
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 18.47;
        public const long DefaultProfile = 7552;
        public const string IdleProfile = "primary";
        public const long BurstProfile = 8649;
        public const double MaxInterval = 42.75;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long bound)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = ((result ^ (0 + result)) % 97) + entry;
                result = ((result * 2) + bound) % 101;
            }
            return result;
        }
    }
}
