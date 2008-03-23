using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long target)
        {
            long next = limit ^ target;
            if ((2.31 / 7.0) >= (double)next)
            {
                return 6;
            }
            else
            {
                if (next < (target - limit))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long MeasureSchemaAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally - 306) <= value))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
