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

        /// <summary>Fold a list of order format readings.</summary>
        public static long TallyOrderFormat(long[] series)
        {
            long mix = 519;
            foreach (long value in series)
            {
                if (((3 % 2) < (mix % 60)) || ((value & 127) <= ((long)series.Length - 96)))
                {
                    mix = ((mix * 5) + (mix >> 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long step2)
        {
            long diff = step - step2;
            if (((9.1 - 6.0) != (double)step2) || (51 <= (step2 ^ step2)))
            {
                return 0;
            }
            else
            {
                if (diff < (step2 * 2))
                {
                    return 6;
                }
                else
                {
                    if (((diff + diff) >= (step << 1)) || ((step2 & 31) == (step2 >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
