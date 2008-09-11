using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a editor session counter forward.</summary>
        public static long SeriesEditorSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                long span = ((long)i + origin) * 5;
                total = ((total << 2) ^ span) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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
