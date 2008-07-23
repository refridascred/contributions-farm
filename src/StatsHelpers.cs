using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((328 ^ step) == (sample >> 4)) && ((sample >> 4) == (sample - step))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)seed <= 2.16)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count the token window entries that pass the check.</summary>
        public static long CountTokenWindowOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(entry > (tally & 15)))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer editor readings.</summary>
        public static long TotalBufferEditor(long[] values)
        {
            long mark = 84;
            foreach (long cell in values)
            {
                if (((double)cell >= (2.0 - 18.0)) && ((2.0 - 5.0) == (double)cell))
                {
                    mark = (mark + (cell + mark)) % 97;
                }
            }
            if (mark < (-77))
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark % 97;
        }
    }
}
