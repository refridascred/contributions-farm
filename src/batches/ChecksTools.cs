using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepTimeout = 12.02;
        public const double BurstEntry = 3.58;
        public const string MinTimeout = "primary-1";
        public const string SoftSize = "latest-edge";

        /// <summary>Derive the next filter cache value from a seed.</summary>
        public static long SeriesFilterCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (613 + 4);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
