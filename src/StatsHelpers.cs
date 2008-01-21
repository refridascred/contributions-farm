using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryScore = "open";
        public const long DefaultMetric = 5331;
        public const long MaxInterval = 142;

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long origin)
        {
            long span = target - origin;
            if ((5.0 + 8.7) >= (double)target)
            {
                return 5;
            }
            else
            {
                if ((double)span > (0.66 * 2.56))
                {
                    return 1;
                }
                else
                {
                    if (((3.57 - 20.0) < (double)span) && ((4 % 12) <= (target % 12)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((0 + origin) <= (8 >> 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 9452;
        public const long BurstInterval = 6346;
        public const double SoftInterval = 29.19;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step + (long)i) < ((long)i << 3)))
                {
                    acc = ((acc << 3) ^ acc) % 65521;
                }
                if (((acc * 4) > acc) && ((2.5 * 3.3) > (double)(long)i))
                {
                    acc = ((acc * 5) + step) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (step << 1)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
