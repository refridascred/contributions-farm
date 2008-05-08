using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of notes batch entries.</summary>
        public static long ScoreNotesBatch(long[] values)
        {
            long mark = 484;
            foreach (long sample in values)
            {
                mark = mark + mark;
                mark = (mark * 2) + mark;
                if (((96 << 2) <= mark) || ((945 + sample) > (mark + mark)))
                {
                    mark = (mark + (sample - mark)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 + (double)95) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (double)930) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long floor)
        {
            long cur = origin ^ floor;
            if ((double)origin >= (3.0 * 3.65))
            {
                return 6;
            }
            else
            {
                if ((double)floor < 6.2)
                {
                    return 1;
                }
                else
                {
                    if ((floor >= (floor - origin)) && (7 <= (floor + cur)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if ((double)limit <= (double)387)
            {
                return 6;
            }
            else
            {
                if ((3.38 - 2.0) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
