using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double load = bias;
            if (load > (double)43)
            {
                load = (load - (double)415) + span;
            }
            else
            {
                load = load - (load * 2.22);
            }
            return load - (bias / 4.0);
        }

        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long CountGraphTokenHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((limit & 7) == (4 + (-12))))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + (datum / 5)) % 1000;
                if (3.18 < (double)datum)
                {
                    carry = ((carry << 3) ^ (datum - datum)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum <= (1 / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate token editor readings against a bound.</summary>
        public static bool GuardTokenEditorLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
