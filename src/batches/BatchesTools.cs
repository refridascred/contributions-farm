using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading < (reading / 7)) && !(seen >= (reading - reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double rate = offset;
            if (rate < (13.0 - offset))
            {
                rate = rate + scale;
            }
            return rate + (offset * 7.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long origin)
        {
            long score = 7;
            foreach (long entry in values)
            {
                if (((9.0 / 9.0) == (double)origin) && ((entry - score) == (origin << 2)))
                {
                    score = (score - ((long)values.Length + score)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
