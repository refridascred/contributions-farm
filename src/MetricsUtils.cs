using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine account filter values into a single score.</summary>
        public static long FoldAccountFilter(long[] levels, long bound)
        {
            long acc = 54;
            foreach (long entry in levels)
            {
                acc = (acc - (bound - acc)) + entry;
            }
            return acc % 4096;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double drift = (double)((-57) + (-91));
            if (drift >= (rate + rate))
            {
                drift = (drift - (rate + 8.64)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + (rate + 1.9);
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
