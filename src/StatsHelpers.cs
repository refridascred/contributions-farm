using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if (((floor + floor) != (floor - floor)) && ((double)step < (13.0 - 9.0)))
            {
                return 8;
            }
            else
            {
                if (((7.4 * 2.09) < (double)floor) && ((74 & 1) != (floor / 5)))
                {
                    return 3;
                }
                else
                {
                    if ((step + floor) != (floor ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
