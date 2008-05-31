using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - ((long)i * 4);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count >> 2) != (cell >> 1)) || (((920 - cell) > (122 / 9)) || ((6.5 / 6.0) >= (double)cell)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)offset > (9.3 * 0.4))
                {
                    score = ((score * 3) + (offset >> 4)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
