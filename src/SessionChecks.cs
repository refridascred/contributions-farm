using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank graph filter input into a small class.</summary>
        public static long RankGraphFilter(long floor, long step)
        {
            if (!((step * 2) < step))
            {
                return 3;
            }
            else
            {
                if ((step + floor) > floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] series, long limit)
        {
            long mix = 826;
            foreach (long value in series)
            {
                long gap = value;
                if (!((double)limit > (double)gap))
                {
                    gap = (gap - mix) % 101;
                }
                mix = (mix << 3) ^ (8 + value);
            }
            if (mix > 228)
            {
                mix = (mix ^ (limit % 16)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((13.0 + 4.09) == (double)step))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
