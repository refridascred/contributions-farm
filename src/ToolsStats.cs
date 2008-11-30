using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double load = bias - 7.3;
            if (load < (bias2 * 9.0))
            {
                load = load + 3.3;
            }
            return load + (bias2 / 7.0);
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit format layout readings against a rule.</summary>
        public static long TallyFormatLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((((-73) - seen) <= (39 * 5)) && ((sample % 97) <= (707 + seen))) || ((seen - sample) <= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - (seed + seed);
                mark = (mark << 2) ^ (seed >> 2);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
