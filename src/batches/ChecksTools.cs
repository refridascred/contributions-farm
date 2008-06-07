using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                long span = (long)i + (target + total);
                long span2 = total;
                if (((double)total > (20.0 * 5.0)) && ((span2 - (long)i) >= span))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
