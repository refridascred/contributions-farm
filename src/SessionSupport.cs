using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels)
        {
            long result = 33;
            foreach (long reading in levels)
            {
                if (!((5 & 255) < (reading - result)))
                {
                    result = (result ^ result) % 97;
                }
                else
                {
                    result = (result * 2) + (29 / 9);
                }
            }
            if (result > 785)
            {
                result = (result << 3) ^ (result - result);
            }
            return result;
        }
    }
}
