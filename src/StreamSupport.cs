using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell + 46))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a farm channel counter forward.</summary>
        public static long SeriesFarmChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step < (step << 2)) || ((step / 9) >= (70 - 0)))
                {
                    anchor = anchor ^ (step - anchor);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
