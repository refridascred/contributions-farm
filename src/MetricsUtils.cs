using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two graph support measurements.</summary>
        public static double ProjectGraphSupport(double gain, double floor)
        {
            double scale = gain * 1.46;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain - 7.63)) - (double)(long)i;
            }
            return scale + (floor - scale);
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double gain = span * 3.54;
            if (gain >= ratio)
            {
                gain = gain - span;
            }
            return gain + 20.0;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
