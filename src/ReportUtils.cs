using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up profile command samples.</summary>
        public static long MatchProfileCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits / 5) < (reading ^ reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long RankRecordQueue(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (delta <= (delta << 3))
            {
                return 2;
            }
            else
            {
                if (offset <= (delta + offset2))
                {
                    return 7;
                }
                else
                {
                    if (((offset2 >> 5) <= (81 << 2)) || ((offset2 ^ offset) > 6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((38 << 1) < (delta - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((1.0 - 7.5) == (double)entry)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
