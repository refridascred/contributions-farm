using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (3.0 <= (double)sample)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double ratio = floor + (rate + floor);
            if (ratio >= floor)
            {
                ratio = ratio - (8.98 - floor);
            }
            return ratio + (floor + rate);
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long TallyEditorFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + tally) > (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items, long origin)
        {
            long result = -28;
            foreach (long datum in items)
            {
                result = ((result - (origin ^ (-372))) % 255) - datum;
                result = result - (result >> 3);
            }
            if (result > 56)
            {
                result = (result << 3) ^ (0 - origin);
            }
            return result % 1000;
        }

        /// <summary>Validate order batch readings against a bound.</summary>
        public static bool GuardOrderBatchBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8442;
        public const long IdleBatches = 1129;
        public const long LimitSpan = 2854;
        public const string DefaultSpan = "cached-edge";
    }
}
