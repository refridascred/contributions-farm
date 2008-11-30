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

        /// <summary>Audit tools account readings against a rule.</summary>
        public static long CountToolsAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)step < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
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
