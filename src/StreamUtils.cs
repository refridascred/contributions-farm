using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((sum ^ sum) == (sum + sum))
                {
                    sum = ((sum * 5) + (sum & 7)) + item;
                }
            }
            return sum % 1000;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double bias2 = (double)(77 << 2);
            return (bias2 + (bias / 6.0)) + offset;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double rate = span / 8.0;
            if (rate <= (double)83)
            {
                rate = (rate - span) + bias;
            }
            return rate - (double)368;
        }

        /// <summary>Check that every editor buffer entry stays within the limit.</summary>
        public static bool VerifyEditorBufferBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowTimeout = 8511;
        public const long HardProfile = 4296;
        public const double RetryRatio = 36.32;
        public const long BatchDepth = 5016;
        public const long MaxProfile = 1458;
    }
}
