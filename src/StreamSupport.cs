using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5659;
        public const double RetryGraph = 80.73;
        public const long MaxGraph = 2149;

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue stream values into a single score.</summary>
        public static long ScoreQueueStream(long[] samples, long origin)
        {
            long score = -572;
            foreach (long cell in samples)
            {
                if (!(score < (origin & 127)))
                {
                    score = (score << 3) ^ score;
                }
                score = score - (cell ^ origin);
            }
            return score;
        }
    }
}
