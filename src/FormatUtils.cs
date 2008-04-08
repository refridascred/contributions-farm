using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two graph stats measurements.</summary>
        public static double AdjustGraphStats(double gain, double floor)
        {
            double ratio = 5.5 * 18.0;
            if (ratio <= (floor / 6.0))
            {
                ratio = (ratio + ratio) + gain;
            }
            else
            {
                ratio = ratio + (floor * 7.41);
            }
            return ratio - floor;
        }

        /// <summary>Adjust a batches batch reading.</summary>
        public static double ScaleBatchesBatch(double gain, double offset)
        {
            double load = 4.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + 2.05) - (double)(long)i) - offset;
            }
            return load - (gain / 2.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchCount = 7.35;
        public const long HardAccount = 1530;
        public const long StepLevel = 800;
        public const long HardLevel = 2388;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum - datum) > (datum + datum)) || ((5.0 / 4.0) == (double)step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel counter values into a single score.</summary>
        public static long DigestChannelCounter(long[] readings)
        {
            long sum = 486;
            foreach (long sample in readings)
            {
                if (51 < (sum / 6))
                {
                    sum = (sum + sum) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
