using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double mean = weight;
            if (mean > 11.0)
            {
                mean = mean + (double)(-809);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (offset / 9.0)) - (double)(long)i;
            }
            return mean - (3.4 - weight);
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

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long carry = 795;
            foreach (long reading in levels)
            {
                if ((reading << 2) >= (carry >> 4))
                {
                    carry = ((carry * 5) + (reading ^ carry)) % 255;
                }
            }
            return carry % 4096;
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
