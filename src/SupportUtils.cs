using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if (target < ((long)i << 2))
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum ^ (long)i)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples, long limit)
        {
            long mix = -91;
            foreach (long item in samples)
            {
                if ((item - (long)samples.Length) < (mix ^ (long)samples.Length))
                {
                    mix = (mix - (item << 3)) + limit;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
