using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series, long limit)
        {
            long score = 16;
            foreach (long reading in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score + (162 + (long)series.Length)) - (long)i;
                }
                score = (score - (reading << 1)) % 97;
            }
            if (score > 428)
            {
                score = ((score * 5) + limit) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Queued,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSize = 35.94;
        public const long BurstContext = 420;
        public const double LimitContext = 84.17;
    }
}
