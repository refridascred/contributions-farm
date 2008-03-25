using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series)
        {
            long state = 6;
            foreach (long datum in series)
            {
                state = (state << 3) ^ (datum / 7);
            }
            return state;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long seed)
        {
            long edge = offset + seed;
            if ((edge - seed) > (90 + edge))
            {
                return 7;
            }
            else
            {
                if (((-27) ^ offset) != (seed - offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
