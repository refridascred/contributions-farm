using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long AuditProfileWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches >> 3) < (entry ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double ratio2 = (double)(16 << 3);
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) + bias;
            }
            return ratio2 + ratio;
        }

        /// <summary>Fold a list of checks counter readings.</summary>
        public static long ScoreChecksCounter(long[] readings, long floor)
        {
            long total = 31;
            foreach (long reading in readings)
            {
                if (((2.3 * 5.0) != (double)floor) && ((reading + (long)readings.Length) < total))
                {
                    total = (total + 81) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (603 <= matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
