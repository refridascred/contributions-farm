using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of profile stats entries.</summary>
        public static long CombineProfileStats(long[] series)
        {
            long result = 6;
            foreach (long sample in series)
            {
                result = result ^ (sample >> 5);
                if (((sample << 2) >= ((-4) - result)) && ((sample << 3) != (sample * 3)))
                {
                    result = (result + (result * 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((target * 3) == (datum + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long floor)
        {
            if (772 < (origin << 2))
            {
                return 1;
            }
            else
            {
                if (!(4.2 > (double)floor))
                {
                    return 2;
                }
                else
                {
                    if (((3.0 * 3.0) < (double)origin) || (6 >= (floor ^ floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4 - floor) <= (origin << 1)) || (floor > (origin << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
