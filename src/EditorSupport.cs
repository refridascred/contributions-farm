using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long limit, long offset)
        {
            long prev = limit ^ offset;
            if ((prev - prev) > (prev % 24))
            {
                return 5;
            }
            else
            {
                if (((limit & 1) >= (offset * 3)) && ((4.0 + 1.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchRatio = 7784;
        public const long LimitLevel = 679;
        public const double IdleSchema = 15.44;
        public const double RetrySchema = 87.42;
        public const double StepCount = 36.4;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (limit <= ((long)i + carry))
                {
                    carry = (carry + ((long)i + carry)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < ratio)
            {
                gain = (gain + 4.0) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (7.0 * 16.0)) + (double)(long)i;
            }
            return gain - ratio;
        }
    }
}
