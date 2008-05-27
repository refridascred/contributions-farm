using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((double)floor < (14.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if ((3 << 2) > (floor & 127))
                {
                    return 1;
                }
                else
                {
                    if ((4.8 / 6.0) != (double)floor2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((offset & 31) <= (offset & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1843;
        public const long StepWidth = 2371;
        public const long StepMetrics = 3989;
        public const long SoftSpan = 1127;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double scale = gain;
            if (scale < floor)
            {
                scale = scale - (gain - gain);
            }
            else
            {
                scale = scale - gain;
            }
            return scale - 14.0;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample & 127) < (64 + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
