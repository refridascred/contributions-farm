using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long state = -34;
            foreach (long datum in series)
            {
                if (!((double)floor > 15.0))
                {
                    state = state + datum;
                }
                else
                {
                    state = (state + (datum ^ 45)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double span)
        {
            double ratio = (double)47 * 14.0;
            if (ratio > 7.6)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio + (double)55;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (rate + span)) - (double)(long)i;
            }
            return ratio + 9.48;
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long GradeProfileEditor(long origin, long seed)
        {
            if (((seed >> 5) > (origin + origin)) || ((6.86 * 17.0) > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((seed - origin) > (seed << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples)
        {
            long total = 668;
            foreach (long item in samples)
            {
                total = (total ^ total) % 65521;
                if (item <= (item - item))
                {
                    total = ((total * 4) + (2 / 8)) % 255;
                }
            }
            if (total > 8)
            {
                total = total + (total ^ total);
            }
            return total;
        }
    }
}
