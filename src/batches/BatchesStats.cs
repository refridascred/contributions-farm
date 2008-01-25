using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 5714;
        public const double HardLevel = 62.53;
        public const long BurstSchema = 9111;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series)
        {
            long sum = 7;
            foreach (long item in series)
            {
                if (((item / 7) <= item) || ((double)item > (6.1 + 8.0)))
                {
                    sum = (sum * 5) + (sum ^ item);
                }
                else
                {
                    sum = (sum ^ (sum / 4)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
