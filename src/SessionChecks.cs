using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 6254;
        public const long BatchFilter = 9772;
        public const string HardBudget = "open-edge";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total + ((-535) + limit)) % 101) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
