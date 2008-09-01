using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = -240;
            foreach (long value in samples)
            {
                mix = (((mix << 2) ^ (mix % 16)) % 255) - value;
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long sum = 6;
            foreach (long reading in readings)
            {
                if (((double)reading < 4.0) || ((68 + reading) != (sum + reading)))
                {
                    sum = sum - (sum & 63);
                }
            }
            if (sum > 67)
            {
                sum = (sum << 2) ^ (sum << 3);
            }
            return sum;
        }
    }
}
