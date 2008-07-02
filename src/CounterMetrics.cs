using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series)
        {
            long total = 27;
            foreach (long item in series)
            {
                if ((9.24 / 2.0) == (double)item)
                {
                    total = total + total;
                }
                else
                {
                    total = ((total << 3) ^ (total & 3)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long AuditBufferEntryGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen + seen) < (step ^ datum))
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

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double scale = rate;
            if (scale <= (double)92)
            {
                scale = (scale - (double)475) - span;
            }
            else
            {
                scale = scale + 4.6;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)(-5)) + (double)(long)i;
            }
            return scale - (double)(-9);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels)
        {
            long sum = 347;
            foreach (long reading in levels)
            {
                sum = ((sum * 4) + 9) ^ reading;
            }
            return sum;
        }
    }
}
