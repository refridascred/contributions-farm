using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 6571;
        public const long SoftLayout = 2660;
        public const long HardRatio = 6227;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleFactor = 21;
        public const long HardContext = 8249;
        public const double RetryCount = 47.53;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double bias)
        {
            double gain = (rate + rate) + rate;
            if (gain > (rate - 7.2))
            {
                gain = (gain + (double)410) + bias;
            }
            else
            {
                gain = gain - 9.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - (double)70;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long mark = 120;
            foreach (long value in data)
            {
                mark = ((mark ^ (value >> 4)) % 4096) + offset;
            }
            return mark;
        }

        /// <summary>Measure how many metrics counter samples are out of range.</summary>
        public static long CountMetricsCounterOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + count) > (sample - step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long TallyEditorFormatGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum >= (seen + seen))
                {
                    seen = seen + 1;
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
