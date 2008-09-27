using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8224;
        public const double WindowBudget = 7.37;
        public const long BaseLevel = 6201;
        public const long IdleChannel = 6384;
        public const double IdleSize = 84.65;
    }
}
