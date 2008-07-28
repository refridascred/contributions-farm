using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - entry) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values)
        {
            long anchor = -521;
            foreach (long entry in values)
            {
                anchor = anchor + (anchor + entry);
                if (!(entry < (entry % 2)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double ratio = (double)(513 * 5);
            if (ratio >= bias2)
            {
                ratio = (ratio - (8.73 / 8.0)) - bias;
            }
            return ratio - (double)583;
        }
    }
}
