using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 478;
            foreach (long reading in items)
            {
                if (reading >= (reading * 3))
                {
                    state = ((state * 2) + (state >> 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            if ((double)floor != (3.67 / 2.0))
            {
                return 6;
            }
            else
            {
                if (!((floor << 1) <= (floor >> 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
