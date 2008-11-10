using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long origin)
        {
            long mix = 448;
            foreach (long reading in readings)
            {
                if ((reading < mix) || ((mix + origin) < (mix + 707)))
                {
                    mix = ((mix * 5) + origin) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long target)
        {
            long result = 184;
            foreach (long cell in samples)
            {
                if ((6 & 31) != (result ^ result))
                {
                    result = ((result << 2) ^ result) + target;
                }
                result = result ^ cell;
            }
            return result;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((sum > (sum >> 2)) || ((seed + 5) >= (sum ^ seed)))
                {
                    sum = ((sum * 4) + (long)i) % 101;
                }
                else
                {
                    sum = sum - (sum % 7);
                    sum = (sum + (5 >> 5)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double load = (double)(59 + 300);
            if (load <= rate)
            {
                load = (load + (5.0 + rate)) - span;
            }
            return load + (double)92;
        }
    }
}
