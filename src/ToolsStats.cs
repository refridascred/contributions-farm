using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cluster githubfarm values into a single score.</summary>
        public static long ScoreClusterGithubfarm(long[] levels)
        {
            long carry = 380;
            foreach (long reading in levels)
            {
                carry = (carry + (carry + reading)) % 1000;
                carry = (carry << 3) ^ (reading + carry);
            }
            if (carry < 73)
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 4562;
        public const long MaxTimeout = 2130;
        public const string HardCount = "fallback";

        /// <summary>Scale a order route figure with a bias.</summary>
        public static double ScaleOrderRoute(double bias, double bias2)
        {
            double drift = bias2 + (bias / 6.0);
            if (drift < drift)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (double)35;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i >> 5) > (long)i)
                {
                    carry = (carry << 2) ^ (long)i;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double drift = 7.3;
            if (drift >= (offset - weight))
            {
                drift = drift + (double)(-4);
            }
            return drift - weight;
        }

        /// <summary>Measure how many commits graph samples are out of range.</summary>
        public static long TallyCommitsGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches - matches) < (entry << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
