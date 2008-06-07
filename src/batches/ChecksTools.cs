using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long origin)
        {
            if ((734 + 23) < seed)
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) <= (seed / 6))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long target)
        {
            long acc = 74;
            foreach (long datum in series)
            {
                if (!(acc <= target))
                {
                    acc = acc + (datum + datum);
                }
            }
            if (acc > 64)
            {
                acc = (acc + (target - 60)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = acc ^ (target * 4);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
