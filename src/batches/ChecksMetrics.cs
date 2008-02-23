using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if (((double)limit >= (7.85 - 8.57)) || ((step % 100) <= (limit << 3)))
            {
                return 2;
            }
            else
            {
                if ((step + step) < (limit + step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a support window figure with a bias.</summary>
        public static double ScaleSupportWindow(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias <= (bias + bias))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (weight - offset)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 39;
            foreach (long sample in items)
            {
                if ((70 ^ sample) == (carry + sample))
                {
                    carry = (carry - (sample - carry)) % 1000;
                }
            }
            if (carry < 6)
            {
                carry = (carry ^ (385 - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Match up already tools samples.</summary>
        public static long PairAlreadyToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long acc = 11;
            foreach (long item in readings)
            {
                if ((item % 64) <= (8 + 690))
                {
                    acc = (acc - (item + item)) % 101;
                }
            }
            if (acc > 63)
            {
                acc = ((acc << 3) ^ (seed - acc)) % 4096;
            }
            return acc;
        }
    }
}
