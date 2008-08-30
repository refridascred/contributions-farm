using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Retry,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "staging";
        public const double BurstFarm = 91.57;
        public const string CacheFarm = "stable-1";
        public const string MinScore = "standard-1";

        /// <summary>Project the next session format value.</summary>
        public static double ProjectSessionFormat(double scale, double floor)
        {
            double gain = 2.2;
            if (gain < (double)5)
            {
                gain = ((gain - gain) + scale) - floor;
            }
            return gain + 19.0;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if ((0 * 3) > entry)
                {
                    sum = (sum - (sum ^ sum)) % 101;
                    sum = sum ^ (entry + sum);
                }
                sum = (sum - (82 >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool CheckMetricsEntryRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
