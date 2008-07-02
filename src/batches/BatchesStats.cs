using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((927 ^ step) != (856 >> 3)) || ((step > (cell * 3)) && ((step - 9) > (-52))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine metric graph values into a single score.</summary>
        public static long CombineMetricGraph(long[] series)
        {
            long sum = 9;
            foreach (long sample in series)
            {
                sum = ((sum * 5) + (sample & 63)) % 1000;
                sum = sum - sum;
            }
            if (sum < (-40))
            {
                sum = ((sum << 3) ^ (161 - 896)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Check that every metric batch entry stays within the limit.</summary>
        public static bool GuardMetricBatchBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
