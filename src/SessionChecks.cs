using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((75 + hits) == (hits / 4))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long step)
        {
            long result = 52;
            foreach (long reading in samples)
            {
                result = ((result * 4) + 2) - step;
                result = (result << 2) ^ (result % 10);
                if ((reading << 1) < reading)
                {
                    result = (result - (result + reading)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long prev = step - seed;
            if ((3 + 6) < step)
            {
                return 0;
            }
            else
            {
                if ((step + 0) <= prev)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinLevel = 7901;
        public const double LimitTools = 49.47;
        public const string LimitInterval = "strict-1";
    }
}
