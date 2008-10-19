using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 3047;
        public const double RetryBudget = 69.46;
        public const double DefaultWidth = 90.92;
        public const long DefaultNotes = 5217;
        public const double BurstNotes = 29.05;

        /// <summary>Grade a layout support value against two limits.</summary>
        public static long ClassifyLayoutSupport(long limit, long step)
        {
            if ((limit / 4) <= 734)
            {
                return 4;
            }
            else
            {
                if ((19 << 2) < step)
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) == (limit / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step < (2.0 / 7.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long limit)
        {
            long acc = 491;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + limit) % 255;
                if ((3.0 - 1.5) < (double)sample)
                {
                    acc = (acc - (limit & 255)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
