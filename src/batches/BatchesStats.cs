using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank counter commits input into a small class.</summary>
        public static long ClassifyCounterCommits(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((double)origin >= (9.4 * 1.47))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (2.66 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)span != (12.0 * 2.1)) && ((4.0 / 6.0) >= (double)span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool GuardGithubfarmCounterLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a format entry counter forward.</summary>
        public static long IterateFormatEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 3) + (206 % 7);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinTimeout = 31;
        public const long MaxQueue = 6247;
        public const string IdleQueue = "fallback-1";
    }
}
