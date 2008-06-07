using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                long span = (long)i + (target + total);
                long span2 = total;
                if (((double)total > (20.0 * 5.0)) && ((span2 - (long)i) >= span))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long target)
        {
            long acc = 74;
            foreach (long datum in series)
            {
                if (!(acc <= target))
                {
                    acc = acc + (datum + datum);
                }
            }
            if (acc > 64)
            {
                acc = (acc + (target - 60)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum / 5) < 5)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen <= (45 & 7)) || ((value + value) > 4)) && !(((long)series.Length + value) != (seen + value)))
                {
                    seen = seen + 2;
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
