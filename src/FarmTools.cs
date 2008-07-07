using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats farm readings.</summary>
        public static long MatchStatsFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream record samples are out of range.</summary>
        public static long CountStreamRecordMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((floor + count) < count) && ((cell ^ floor) < (floor << 2))) && ((floor >> 3) < cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((49 >> 2) != (step - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
