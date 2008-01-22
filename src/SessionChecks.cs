using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next stats token value.</summary>
        public static double ProjectStatsToken(double rate, double span)
        {
            double gain = 8.4;
            if (gain > (rate / 5.0))
            {
                gain = (gain + rate) - span;
            }
            else
            {
                gain = gain - 7.1;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 3.19) - (double)(long)i;
            }
            return gain - (gain * 17.0);
        }

        /// <summary>Accumulate session already samples.</summary>
        public static long DigestSessionAlready(long[] values, long seed)
        {
            long acc = 60;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (cell + cell)) % 65521;
                acc = (acc ^ cell) % 1000;
                if (acc <= (1 % 60))
                {
                    break;
                }
            }
            if (acc > 882)
            {
                acc = (acc + (acc + seed)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ mark) ^ reading;
            }
            return mark;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
