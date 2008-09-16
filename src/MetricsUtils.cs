using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
