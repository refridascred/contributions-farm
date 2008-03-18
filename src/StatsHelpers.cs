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

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double rate = span;
            if (rate > weight)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            return rate - (6.6 + span);
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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Paused,
            Closed,
            Ready,
        }
    }
}
