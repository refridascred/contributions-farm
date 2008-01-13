using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue report samples are out of range.</summary>
        public static long MeasureQueueReportMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (5.4 - 2.97))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((6.75 - 8.55) < (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > (double)9)
            {
                rate2 = (rate2 + rate) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (rate * 4.3);
        }
    }
}
