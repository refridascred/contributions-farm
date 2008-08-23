using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double load = 5.6;
            if (load <= load)
            {
                load = load + (load / 2.0);
            }
            else
            {
                load = load + bias;
            }
            return load + (scale - bias);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double load = offset + (4.54 - offset);
            if (load >= (2.0 * 6.98))
            {
                load = (load - offset) - gain;
            }
            return load - (double)68;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long origin, long floor)
        {
            long span = origin + floor;
            if (((0.2 * 2.8) == (double)span) && ((origin >> 4) < 70))
            {
                return 7;
            }
            else
            {
                if (((origin * 4) < (5 - 8)) && ((floor + span) != (span + 60)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + origin) >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
