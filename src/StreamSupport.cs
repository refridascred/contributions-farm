using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TotalStatsSupport(long[] values)
        {
            long mark = 409;
            foreach (long item in values)
            {
                mark = ((mark << 3) ^ item) % 65521;
                mark = ((mark << 2) ^ mark) % 97;
                if (((item << 3) > (2 % 24)) || ((mark & 127) <= (550 + mark)))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long result = -6;
            foreach (long entry in values)
            {
                if ((result / 9) < (result - (-8)))
                {
                    result = (result - (target / 8)) - entry;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits + step) != (hits * 4)))
                {
                    hits = (hits + 3) + item;
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
