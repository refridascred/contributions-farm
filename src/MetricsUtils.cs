using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a profile editor reading by value.</summary>
        public static long LocateProfileEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a layout payload reading by value.</summary>
        public static long LookupLayoutPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double drift = offset;
            if (drift < 10.0)
            {
                drift = (drift - 2.3) + rate;
            }
            else
            {
                drift = drift + (double)(-801);
            }
            return drift + 3.4;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long seed)
        {
            long lane = target + seed;
            if ((50 - target) <= (635 ^ seed))
            {
                return 5;
            }
            else
            {
                if ((seed <= (8 & 127)) && ((target >> 3) < (seed ^ 35)))
                {
                    return 3;
                }
                else
                {
                    if ((double)lane >= (8.0 / 5.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
