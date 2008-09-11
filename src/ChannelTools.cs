using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of route stream readings.</summary>
        public static long TallyRouteStream(long[] values, long bound)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = (sum * 2) + (entry >> 2);
            }
            if (sum < 437)
            {
                sum = (sum ^ bound) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double bias = (rate * 0.2) * 1.9;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + bias) + (double)(long)i) + offset;
            }
            return bias - bias;
        }

        /// <summary>Roll a support checks counter forward.</summary>
        public static long SeriesSupportChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 2) ^ (309 - (-5));
                anchor = ((anchor << 3) ^ 0) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
