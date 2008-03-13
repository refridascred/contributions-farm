using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i * 3) <= (seed + seed))
                {
                    mark = ((mark << 3) ^ (mark - seed)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many schema layout samples are out of range.</summary>
        public static long TallySchemaLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item & 3) <= (-4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (18 >= (seed + seed))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double mean = floor;
            if (mean < floor)
            {
                mean = mean - (double)84;
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - (double)62;
        }
    }
}
