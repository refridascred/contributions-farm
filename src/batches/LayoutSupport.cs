using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long acc = 91;
            foreach (long sample in levels)
            {
                acc = acc + (sample ^ acc);
            }
            if (acc < 4)
            {
                acc = (acc << 2) ^ (limit ^ acc);
            }
            return acc;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((long)series.Length >= (value + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double span)
        {
            double bias = span;
            if (bias >= bias)
            {
                bias = (bias - 5.0) - gain;
            }
            return bias + 5.85;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardWidth = 61.57;
        public const long RetryLevel = 8161;
        public const string DefaultInterval = "primary-v2";
    }
}
