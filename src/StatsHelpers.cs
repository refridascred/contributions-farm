using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long offset)
        {
            if (offset <= (origin + 39))
            {
                return 2;
            }
            else
            {
                if (origin > (origin >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ origin) >= (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift - (span / 4.0);
            }
            else
            {
                drift = drift + (span - span);
            }
            return drift + (drift + scale);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + ((-6) / 4)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a metrics token sample.</summary>
        public static long LocateMetricsTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxLevel = 1505;
        public const long IdleCount = 1700;
        public const double LimitWidth = 33.11;
        public const double LimitInterval = 95.24;
    }
}
