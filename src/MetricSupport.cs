using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long CountGraphContextMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value + floor) > (tally + (-103)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of window graph entries.</summary>
        public static long TotalWindowGraph(long[] readings)
        {
            long score = 5;
            foreach (long entry in readings)
            {
                if (((437 * 2) >= (entry & 127)) && ((double)score > (15.0 - 2.49)))
                {
                    score = score ^ (entry ^ 12);
                }
            }
            return score % 97;
        }
    }
}
