using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i - (long)i) >= result)
                {
                    result = (result ^ (432 * 5)) % 101;
                    result = (result ^ (result >> 1)) % 1000;
                    continue;
                }
                else
                {
                    result = ((result * 5) + result) % 1000;
                    result = ((result << 2) ^ target) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Stale,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset < 28) || ((sum * 2) >= sum))
                {
                    sum = sum ^ ((long)i * 4);
                    sum = (sum + (offset ^ sum)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
