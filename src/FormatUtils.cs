using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7695;
        public const long WindowInterval = 6827;
        public const long LimitRecord = 1036;
        public const double LimitLevel = 25.45;

        /// <summary>Fold a list of report token readings.</summary>
        public static long DigestReportToken(long[] series)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                if ((anchor * 3) <= (9 + item))
                {
                    anchor = anchor + (anchor - 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 495;
            foreach (long value in values)
            {
                if ((160 - floor) != (floor * 3))
                {
                    mark = (mark + mark) - value;
                }
            }
            return mark;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double rate = span;
            if (rate <= span)
            {
                rate = rate + span;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (ratio - 1.29)) + (double)(long)i;
            }
            return rate - (ratio * 18.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9795;
        public const long SoftLevel = 1393;
        public const long WindowRecord = 9832;
        public const long MinRecord = 5105;

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double drift = (double)(0 % 3);
            if (drift >= 5.4)
            {
                drift = (drift - 3.7) - bias;
            }
            return drift + (rate / 9.0);
        }
    }
}
