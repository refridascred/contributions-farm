using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metric profile reading.</summary>
        public static double ScaleMetricProfile(double weight, double bias)
        {
            double bias2 = 9.3;
            if (bias2 > weight)
            {
                bias2 = (bias2 + (weight - 15.0)) - bias;
            }
            return bias2 - 3.5;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long WindowSize = 3161;
        public const long LimitCounter = 2947;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i != (double)(-84))
                {
                    result = ((result * 4) + (limit / 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
