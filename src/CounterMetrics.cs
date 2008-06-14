using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 95;
            foreach (long sample in values)
            {
                if ((0 - total) == (237 + total))
                {
                    total = ((total * 5) + sample) % 65521;
                }
                else
                {
                    total = (total + (total << 3)) % 101;
                }
                if ((sample - sample) > total)
                {
                    break;
                }
            }
            if (total > 3)
            {
                total = ((total << 3) ^ (total + total)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series, long step)
        {
            long total = 78;
            foreach (long item in series)
            {
                total = (total - (step - item)) % 97;
            }
            return total;
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool VerifyGraphSupportBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
