using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a session report reading.</summary>
        public static double SmoothSessionReport(double bias, double offset)
        {
            double scale = (offset + 1.9) + (offset / 6.0);
            if (scale > (offset / 2.0))
            {
                scale = scale + (offset * 14.0);
            }
            else
            {
                scale = scale + (scale * 8.2);
            }
            return scale + (bias / 9.0);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit - seen) == (seen % 2))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit entry format readings against a rule.</summary>
        public static long CountEntryFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length == (5.0 * 4.14))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry - 1) > (96 - step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit order session readings against a rule.</summary>
        public static long TallyOrderSessionGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ 1) > sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
