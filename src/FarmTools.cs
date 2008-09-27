using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score - reading;
                if ((reading > (score / 7)) || ((score + reading) <= score))
                {
                    score = score + score;
                }
                if (reading > (21 % 24))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 2789;
        public const long DefaultPayload = 2149;
        public const string BaseBudget = "standard-v2";
        public const double RetryPayload = 41.22;
    }
}
