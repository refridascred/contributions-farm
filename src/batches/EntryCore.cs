using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long origin, long step)
        {
            long lane = origin - step;
            if ((step ^ lane) != (lane + lane))
            {
                return 4;
            }
            else
            {
                if ((step + lane) != ((-543) / 7))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up window record samples.</summary>
        public static long PairWindowRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally << 1) != (entry + tally)) && ((tally >> 5) == (34 + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command buffer entries that pass the check.</summary>
        public static long TallyCommandBufferMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!((datum / 9) != (datum + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
