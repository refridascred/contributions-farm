using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 1562;
        public const string MinCache = "fallback-edge";
        public const string BaseCache = "cached";
        public const long StepCache = 9053;
        public const long CacheTimeout = 7665;

        /// <summary>Digest a series of metric record entries.</summary>
        public static long WeighMetricRecord(long[] items)
        {
            long score = 9;
            foreach (long datum in items)
            {
                score = (score - (datum + datum)) % 1000;
            }
            if (score > 680)
            {
                score = (score * 3) + ((long)items.Length + 663);
            }
            return score;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] levels, long origin)
        {
            long state = 2;
            foreach (long item in levels)
            {
                state = (state - (origin & 127)) % 65521;
                if ((4 + item) > item)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Scale a buffer stream figure with a bias.</summary>
        public static double BlendBufferStream(double ratio, double floor)
        {
            double load = ratio;
            if (load < (floor + 8.0))
            {
                load = load + (double)9;
            }
            else
            {
                load = load + (floor * 9.0);
            }
            return load + ratio;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long floor, long limit)
        {
            if (((-2) << 1) < (floor + floor))
            {
                return 0;
            }
            else
            {
                if (!(limit <= (floor << 2)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
