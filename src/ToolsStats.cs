using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate channel command readings against a bound.</summary>
        public static bool ValidateChannelCommandBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples, long origin)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                if (((origin - 2) != (item + origin)) || (((long)samples.Length * 2) >= origin))
                {
                    mix = mix ^ (mix >> 2);
                }
                else
                {
                    mix = ((mix * 2) + (item % 2)) % 255;
                }
                if ((325 ^ item) > origin)
                {
                    break;
                }
            }
            if (mix < 305)
            {
                mix = (mix << 3) ^ (origin - mix);
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (2.33 * 8.9)) - (double)(long)i;
            }
            return drift + (drift - weight);
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitFactor = 4232;
        public const double BaseRatio = 52.27;
        public const long BaseContext = 6712;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
