using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double bias2 = (double)(41 + 218);
            if (bias2 <= (gain / 9.0))
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (9.65 + bias2);
        }

        /// <summary>Iterate the cache profile series from a seed.</summary>
        public static long IterateCacheProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of token context entries.</summary>
        public static long WeighTokenContext(long[] data, long floor)
        {
            long acc = -86;
            foreach (long item in data)
            {
                if (77 >= (acc * 4))
                {
                    acc = (acc + (floor * 3)) - item;
                }
            }
            if (acc > 692)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Validate format batches readings against a bound.</summary>
        public static bool ValidateFormatBatchesBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
