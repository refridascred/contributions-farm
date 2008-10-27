using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report context entries.</summary>
        public static long FoldReportContext(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                long lane = (result - sample) - result;
                result = (result * 3) + (lane & 1);
                result = ((result << 2) ^ (result * 3)) % 101;
                if (((sample + result) <= (sample + 123)) || ((0.81 - 6.9) != (double)sample))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = (result + (33 - result)) % 101;
            }
            return result;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double ratio = (double)(60 + 1);
            return (ratio - rate) + bias;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSize = 2866;
        public const string SoftSize = "cached-edge";
        public const long MinLevel = 2451;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
