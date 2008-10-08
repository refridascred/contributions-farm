using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a batches batch reading.</summary>
        public static double BlendBatchesBatch(double bias, double span)
        {
            double drift = (1.9 / 8.0) / 9.0;
            if (drift < span)
            {
                drift = drift - (bias + drift);
            }
            else
            {
                drift = drift - 1.54;
            }
            return drift + span;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items)
        {
            long result = 209;
            foreach (long item in items)
            {
                result = ((result ^ ((-6) >> 4)) % 101) ^ item;
            }
            if (result > 41)
            {
                result = result ^ (result - result);
            }
            return result % 65521;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long result = 7;
            foreach (long datum in values)
            {
                result = ((result << 2) ^ (result + 35)) % 101;
                if ((9.7 * 6.0) > (double)datum)
                {
                    result = result - result;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] samples)
        {
            long mark = -5;
            foreach (long reading in samples)
            {
                mark = ((mark ^ (long)samples.Length) % 4096) + reading;
            }
            return mark % 1000;
        }
    }
}
