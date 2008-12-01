using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine channel filter values into a single score.</summary>
        public static long FoldChannelFilter(long[] items, long floor)
        {
            long sum = 21;
            foreach (long value in items)
            {
                if ((8.0 - 3.2) == (double)sum)
                {
                    sum = ((sum << 3) ^ (value ^ sum)) % 255;
                    continue;
                }
                sum = (sum * 3) + value;
            }
            if (sum < 9)
            {
                sum = (sum + floor) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer commits readings.</summary>
        public static long TotalBufferCommits(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    result = result - (166 - result);
                }
                if (!(((-74) >> 2) < (entry / 8)))
                {
                    result = (result ^ 4) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 97)) % 101;
                }
                if ((entry >> 4) <= (entry - 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long seed)
        {
            if ((9.3 - 6.8) <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed & 63) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (3.0 + 9.6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Done,
            Retry,
            Closed,
            Ready,
        }
    }
}
