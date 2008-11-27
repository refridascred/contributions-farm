using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double offset)
        {
            double scale = (double)604;
            if (scale <= scale)
            {
                scale = (scale - 8.0) - rate;
            }
            else
            {
                scale = scale + (double)82;
            }
            return scale - (offset / 3.0);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if ((double)anchor != (8.0 * 5.0))
                {
                    anchor = (anchor * 2) + (530 + entry);
                }
                else
                {
                    anchor = (anchor * 3) + (anchor + 250);
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long AuditBufferFilterHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit - limit) >= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
