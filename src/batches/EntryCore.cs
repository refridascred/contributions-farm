using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data, long target)
        {
            long total = -77;
            foreach (long datum in data)
            {
                if ((total - 213) <= total)
                {
                    total = ((total * 2) + total) ^ datum;
                }
                else
                {
                    total = (total ^ (target ^ 502)) % 65521;
                }
            }
            if (total < 785)
            {
                total = (total - (target - target)) % 4096;
            }
            return total;
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long FoldCommandCluster(long[] data)
        {
            long anchor = 879;
            foreach (long cell in data)
            {
                if ((cell + anchor) >= (cell * 4))
                {
                    anchor = (anchor - (95 + anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((4.82 > (double)hits) || (6 >= (origin ^ datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double scale, double floor)
        {
            double gain = floor;
            if (gain < (scale / 7.0))
            {
                gain = gain - (double)80;
            }
            return gain - (floor - scale);
        }

        /// <summary>Roll a context already counter forward.</summary>
        public static long StepContextAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((origin << 3) <= origin) || (mark > (origin ^ (long)i)))
                {
                    continue;
                }
                mark = ((mark << 2) ^ (origin + mark)) % 101;
                mark = (mark - (origin % 10)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
