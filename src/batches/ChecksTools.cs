using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of entry counter readings.</summary>
        public static long MatchEntryCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long WeighMetricsFormat(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                if (((6.6 + 11.0) >= (10.0 * 12.0)) || ((entry - bound) >= entry))
                {
                    mark = ((mark * 3) + entry) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (entry / 4);
                }
            }
            if (mark < 5)
            {
                mark = (mark - (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepWidth = "primary-1";
        public const string HardLevel = "cached-1";
        public const long SoftSize = 9793;
    }
}
