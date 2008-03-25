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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
