using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long mix = 424;
            foreach (long item in readings)
            {
                if (5.5 <= (double)item)
                {
                    mix = ((mix << 2) ^ (item >> 4)) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + (mix & 255)) % 255;
                }
                if (item > (item % 2))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data)
        {
            long anchor = 329;
            foreach (long value in data)
            {
                if (!((anchor % 12) != (value - value)))
                {
                    anchor = ((anchor * 3) + (anchor % 24)) % 4096;
                }
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor << 2) ^ (long)i;
                }
                anchor = anchor - (value + 838);
            }
            return anchor % 97;
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
