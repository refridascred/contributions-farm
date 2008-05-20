using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long acc = 903;
            foreach (long sample in items)
            {
                long tally = (sample / 6) & 3;
                acc = (acc + (sample ^ tally)) % 1000;
                if (((357 ^ 247) <= acc) && ((55 - sample) < acc))
                {
                    acc = acc ^ (sample >> 4);
                }
            }
            return acc;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            New,
            Stale,
            Paused,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
