using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((long)samples.Length <= (hits + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a command support figure with a bias.</summary>
        public static double ScaleCommandSupport(double ratio, double span)
        {
            double scale = (span / 9.0) - (span + ratio);
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + 19.0;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value <= (matches - value)) && ((value >> 3) > (matches & 255)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
