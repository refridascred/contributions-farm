using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every order account entry stays within the limit.</summary>
        public static bool VerifyOrderAccountRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
