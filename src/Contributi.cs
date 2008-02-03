using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long TallyStreamProfileHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (2.49 <= (double)step)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((bound2 / 2) >= bound)
            {
                return 1;
            }
            else
            {
                if ((1.85 * 18.0) != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((floor & 7) >= floor) && ((84 >> 5) == (floor + 51)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
