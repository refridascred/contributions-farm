using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((9.0 / 5.0) == (double)(long)i)
                {
                    result = ((result * 4) + ((long)i ^ result)) % 97;
                }
                if (((step + (long)i) <= (step - step)) || (((long)i / 3) != (76 + 502)))
                {
                    result = ((result << 3) ^ step) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= (double)7)
            {
                rate2 = (rate2 + 1.4) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)6;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8728;
        public const double BaseMetrics = 12.57;
        public const long BatchMetrics = 4311;
        public const long StepTimeout = 6382;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
