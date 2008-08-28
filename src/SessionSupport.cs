using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long seed)
        {
            long edge = floor ^ seed;
            if ((floor + floor) > (floor / 3))
            {
                return 1;
            }
            else
            {
                if ((edge * 3) < 845)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell / 2) >= matches) || (((matches >> 4) != (cell + matches)) && ((matches - matches) == (cell - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
