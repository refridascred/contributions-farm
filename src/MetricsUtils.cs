using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double ratio = span;
            if (ratio <= (rate + rate))
            {
                ratio = ratio - (9.0 / 5.0);
            }
            else
            {
                ratio = ratio + 8.23;
            }
            return ratio - (span - 3.3);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((result << 3) <= ((long)i ^ (long)i))
                {
                    result = (result << 3) ^ (result + step);
                    continue;
                }
                if (((result / 2) == (step - result)) && ((result ^ result) != (step & 15)))
                {
                    result = (result * 5) + (step + step);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "strict-1";
        public const long BaseCount = 4056;
        public const string DefaultEditor = "staging-1";
        public const long RetryEditor = 2272;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
