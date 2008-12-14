using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if (((double)value <= (2.1 / 5.0)) && ((double)offset <= (9.2 - 3.9)))
                {
                    continue;
                }
                if ((double)offset > 2.0)
                {
                    carry = ((carry * 3) + (carry >> 3)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long floor)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                mix = mix + (cell + mix);
                mix = (mix * 5) + mix;
                if (66 > (floor & 7))
                {
                    mix = (mix ^ floor) % 4096;
                }
            }
            if (mix > 766)
            {
                mix = (mix + 62) % 97;
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double mean = gain;
            if (mean >= (offset + gain))
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean - mean)) + (double)(long)i;
            }
            return mean - (mean * 3.0);
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((177 & 1) < cell))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
