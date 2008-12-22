using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((total >= ((long)i & 63)) || (((long)i / 7) <= 19))
                {
                    total = (total ^ (seed - (long)i)) % 97;
                }
                if ((long)i < (total - seed))
                {
                    total = total + (seed / 6);
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((1.17 + 9.25) > (double)tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((2.51 + 2.0) <= (double)value) && ((long)levels.Length >= 582)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
