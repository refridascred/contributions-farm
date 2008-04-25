using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data)
        {
            long result = 7;
            foreach (long entry in data)
            {
                if ((result <= (result & 63)) && (result <= (70 % 10)))
                {
                    result = result - result;
                }
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 3) + entry) % 255) + (long)i;
                }
                result = (result - (21 % 2)) % 255;
            }
            if (result < 88)
            {
                result = (result - result) % 255;
            }
            return result;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + count) < value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
