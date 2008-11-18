using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "standard-1";
        public const double WindowReport = 75.89;
        public const long HardReport = 8920;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long step)
        {
            long next = floor + step;
            if (((next % 2) < (next / 6)) || ((next * 4) > (step / 8)))
            {
                return 6;
            }
            else
            {
                if (!((double)586 == (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((3.88 / 8.0) != (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step & 63) < floor) || (66 < (next * 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
