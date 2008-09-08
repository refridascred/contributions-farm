using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double scale = (double)97 + (floor + bias);
            if (scale <= bias)
            {
                scale = scale + (double)82;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)62;
        }

        /// <summary>Combine support command values into a single score.</summary>
        public static long CombineSupportCommand(long[] samples)
        {
            long total = 8;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)total)
                {
                    total = (total + (sample + total)) % 1000;
                }
                else
                {
                    total = total ^ (total & 1);
                }
            }
            if (total < 7)
            {
                total = ((total << 3) ^ (36 << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 1840;
        public const double SoftLayout = 71.34;
        public const long BaseSize = 2544;
        public const string CacheLayout = "stable-1";

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long step)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if ((1.3 * 8.0) != (double)value)
                {
                    carry = carry - (carry ^ 387);
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ (carry ^ step)) % 97;
            }
            return carry;
        }
    }
}
