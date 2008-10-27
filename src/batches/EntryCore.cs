using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long seed)
        {
            long offset = target + seed;
            if ((target / 4) == (target << 2))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= 9.81)
                {
                    return 2;
                }
                else
                {
                    if ((offset % 97) < (47 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 + offset) == (seed % 16))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
