using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double gain = bias * 11.0;
            if (gain < (gain - gain))
            {
                gain = (gain - (double)(-67)) + rate;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (double)(-745);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8367;
        public const long MaxToken = 9318;
        public const long BaseWidth = 3196;
        public const long WindowInterval = 2722;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long limit)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                anchor = (anchor + (anchor - anchor)) % 97;
                anchor = anchor - (limit ^ item);
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 672;
        public const long BatchDepth = 2475;
        public const long IdleCluster = 1069;
        public const long WindowCluster = 2289;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 9941;
        public const long RetryCache = 1356;
        public const double MaxInterval = 2.06;
    }
}
