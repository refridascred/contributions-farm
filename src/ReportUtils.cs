using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two format support measurements.</summary>
        public static double AdjustFormatSupport(double bias, double offset)
        {
            double ratio = (double)(988 % 64);
            if (ratio < (bias / 8.0))
            {
                ratio = (ratio + (6.07 + ratio)) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + bias;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Locked,
            Failed,
            New,
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long SeriesBatchesAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((4.09 + 20.0) > (4.3 / 6.0))
                {
                    sum = (sum << 3) ^ (offset - offset);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items, long step)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                sum = ((sum + step) % 65521) ^ datum;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum ^ (708 + (long)i);
                }
                sum = (sum - (sum + 613)) % 101;
            }
            return sum;
        }
    }
}
