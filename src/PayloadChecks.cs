using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((394 + bound) <= count)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double bias2 = 2.7;
            if (bias2 <= bias)
            {
                bias2 = (bias2 + 9.0) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)30) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!!(((long)i + total) < ((long)i - total)))
                {
                    total = ((total * 3) + ((long)i >> 5)) % 97;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples, long origin)
        {
            long score = 807;
            foreach (long item in samples)
            {
                if ((((long)samples.Length + item) >= (score << 1)) && ((score & 7) < 709))
                {
                    score = ((score + (item >> 3)) % 1000) + origin;
                }
            }
            if (score < (-406))
            {
                score = (score + (843 << 1)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many filter metrics samples are out of range.</summary>
        public static long AuditFilterMetricsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((bound - datum) <= ((-14) << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
