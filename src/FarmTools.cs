using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin <= (entry << 1)) && ((count - origin) != (6 >> 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ seed;
                result = ((result << 2) ^ ((-20) >> 1)) % 101;
                result = result - ((long)i << 1);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long target)
        {
            long prev = step + target;
            if (target >= (529 + prev))
            {
                return 3;
            }
            else
            {
                if ((target & 255) < (target * 4))
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
