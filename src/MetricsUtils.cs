using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up metrics tools samples.</summary>
        public static long PairMetricsToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a layout route value against two limits.</summary>
        public static long BucketLayoutRoute(long target, long step)
        {
            long step2 = target + step;
            if ((step2 << 1) > step)
            {
                return 7;
            }
            else
            {
                if (target > (target * 2))
                {
                    return 5;
                }
                else
                {
                    if ((0.85 * 8.4) == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (step >= 159)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((993 * 3) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseInterval = 58.2;
        public const double HardContributi = 56.68;
        public const double BaseFactor = 83.39;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
