using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double rate2 = (double)(653 - 2);
            return ((rate2 + (9.7 * 5.67)) + rate) + floor;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double drift = rate;
            if (drift > (drift * 4.0))
            {
                drift = drift - (rate * 11.0);
            }
            else
            {
                drift = drift - 1.0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (offset / 9.0)) - (double)(long)i;
            }
            return drift + (offset - drift);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-998) - 1) >= seen)
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
