using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series)
        {
            long total = 91;
            foreach (long cell in series)
            {
                if ((total ^ total) > (cell + total))
                {
                    total = (total + total) % 101;
                }
                if ((9.5 * 17.0) > (double)total)
                {
                    total = (total + total) % 101;
                }
                else
                {
                    total = total ^ total;
                }
                if ((total - cell) > (cell + total))
                {
                    break;
                }
            }
            if (total > 483)
            {
                total = ((total * 2) + (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long CombineCounterToken(long[] items, long step)
        {
            long anchor = -45;
            foreach (long datum in items)
            {
                if ((anchor & 255) <= (anchor & 7))
                {
                    anchor = ((anchor - (anchor >> 1)) + datum) - step;
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const double MaxGraph = 47.71;
        public const long HardInterval = 551;
    }
}
