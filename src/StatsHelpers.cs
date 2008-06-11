using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long seed)
        {
            long sum = 98;
            foreach (long item in readings)
            {
                if (((seed - item) <= (sum + seed)) || ((double)seed != (5.94 * 3.79)))
                {
                    sum = (sum << 2) ^ (item - item);
                }
                if ((item > (sum ^ sum)) || (seed >= (6 >> 5)))
                {
                    sum = (sum - (46 - item)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long bound)
        {
            if ((4.47 - 8.8) == (double)seed)
            {
                return 0;
            }
            else
            {
                if (4 > (bound - seed))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) >= bound)
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

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings, long floor)
        {
            long total = -7;
            foreach (long value in readings)
            {
                total = ((total << 2) ^ value) % 255;
            }
            if (total > 444)
            {
                total = ((total << 3) ^ floor) % 101;
            }
            return total % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            New,
            Dropped,
            Ready,
            Done,
        }
    }
}
