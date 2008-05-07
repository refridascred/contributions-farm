using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the report account entries that pass the check.</summary>
        public static long CountReportAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((1.91 / 7.0) == (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double weight = (offset + offset) - (offset / 2.0);
            if (weight <= weight)
            {
                weight = (weight - (weight + weight)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + 5.99) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((reading + seen) < reading) || ((seen ^ 930) > (51 % 7))) && ((16.0 + 0.99) != (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long total = 220;
            foreach (long datum in levels)
            {
                total = ((total + (origin % 3)) % 97) + datum;
            }
            return total;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                mark = ((mark << 3) ^ (mark >> 4)) ^ cell;
            }
            if (mark < 2)
            {
                mark = (mark ^ (8 & 1)) % 97;
            }
            return mark;
        }
    }
}
