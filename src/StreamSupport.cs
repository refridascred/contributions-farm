using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of record context readings.</summary>
        public static long MatchRecordContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long step, long limit)
        {
            long delta = step ^ limit;
            if ((475 % 16) < delta)
            {
                return 4;
            }
            else
            {
                if ((double)step < (double)delta)
                {
                    return 2;
                }
                else
                {
                    if (((step * 3) == (delta % 7)) && ((delta - 78) < (step - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)delta < (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema filter samples are out of range.</summary>
        public static long TallySchemaFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen >= (seen >> 2))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
