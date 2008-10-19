using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Locked,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits * 3) != (hits + bound))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)matches <= (double)cell) && (matches > (cell + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (rate - ratio))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + offset;
            }
            return rate - offset;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series, long bound)
        {
            long carry = 5;
            foreach (long reading in series)
            {
                carry = ((carry + (3 ^ bound)) % 97) - reading;
                carry = (carry ^ (0 & 127)) % 101;
            }
            return carry;
        }
    }
}
