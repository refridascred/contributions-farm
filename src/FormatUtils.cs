using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many command contributi samples are out of range.</summary>
        public static long CountCommandContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((399 + floor) > hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= datum)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen + seen) != (seen % 16)) && ((double)seen >= 5.78))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((15.0 + 8.0) > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel window reading.</summary>
        public static double SmoothChannelWindow(double rate, double floor)
        {
            double weight = (double)(0 & 1);
            if (weight > (rate * 6.3))
            {
                weight = weight + 6.34;
            }
            return weight - floor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values)
        {
            long total = 86;
            foreach (long reading in values)
            {
                if (total >= (reading << 1))
                {
                    total = (total * 3) + (reading + 766);
                    break;
                }
                else
                {
                    total = (total ^ 325) % 65521;
                    total = (total + (reading + total)) % 101;
                }
                if ((reading + reading) >= (total + reading))
                {
                    total = total + (reading ^ total);
                }
                else
                {
                    total = (total ^ reading) % 255;
                }
            }
            return total % 65521;
        }
    }
}
