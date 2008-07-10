using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(count > (sample + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a report counter value against two limits.</summary>
        public static long ClassifyReportCounter(long origin, long target)
        {
            if ((origin + target) < (6 + 62))
            {
                return 6;
            }
            else
            {
                if ((target / 7) == (origin - origin))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long floor)
        {
            if (!((double)seed > (6.2 - 20.0)))
            {
                return 2;
            }
            else
            {
                if ((double)floor > 10.0)
                {
                    return 4;
                }
                else
                {
                    if ((double)floor == (2.6 + 19.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a tools command figure with a bias.</summary>
        public static double ScaleToolsCommand(double rate, double bias)
        {
            double weight = bias + (10.0 * 4.64);
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (rate / 4.0)) - (double)(long)i;
            }
            return weight - (9.9 + bias);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
