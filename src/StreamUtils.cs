using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values)
        {
            long mix = 54;
            foreach (long datum in values)
            {
                mix = (mix + (datum << 3)) % 1000;
                if (mix <= (775 / 5))
                {
                    mix = mix - (datum << 3);
                }
                else
                {
                    mix = (mix + (3 >> 3)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4 / 7) >= (item + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSpan = "local-1";
        public const double IdleTimeout = 95.84;
        public const double MaxProfile = 12.08;
        public const long LimitProfile = 3972;
    }
}
