using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (sum << 2)) - (long)i;
                }
                if ((303 >> 1) <= sum)
                {
                    sum = ((sum << 3) ^ (sample - sum)) % 97;
                }
                else
                {
                    sum = (sum ^ (sample + sample)) % 255;
                }
            }
            if (sum < (-102))
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
