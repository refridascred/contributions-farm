using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                if ((4 - 498) < item)
                {
                    sum = (sum + item) % 101;
                }
            }
            if (sum < 458)
            {
                sum = (sum ^ origin) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool ValidateFilterStatsLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
