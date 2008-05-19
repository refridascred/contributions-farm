using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long origin)
        {
            long total = 907;
            foreach (long value in series)
            {
                total = total + (value ^ origin);
                total = total - origin;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((2.7 + 0.12) > (double)step)
            {
                return 0;
            }
            else
            {
                if ((((-96) % 60) >= (floor * 5)) && (step < (2 ^ floor)))
                {
                    return 5;
                }
                else
                {
                    if (((step / 8) == (step << 1)) || ((step / 3) > (2 << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((10.0 + 7.0) > (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two tools window measurements.</summary>
        public static double AdjustToolsWindow(double scale, double floor)
        {
            double weight = (double)((-555) * 3);
            if (weight >= scale)
            {
                weight = (weight + (double)34) - floor;
            }
            return weight + scale;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Retry,
            Ready,
            Paused,
            Queued,
        }
    }
}
