using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepCount = "latest-v2";
        public const long MinSpan = 4034;
        public const string MinFactor = "cached-edge";
        public const string BaseBuffer = "alpha";
        public const double LimitBuffer = 1.56;

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches - matches) < (matches & 31)) && ((entry << 2) == (7 ^ entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double weight = bias;
            if (weight < (double)133)
            {
                weight = (weight + bias) + scale;
            }
            return weight + (bias - bias);
        }
    }
}
