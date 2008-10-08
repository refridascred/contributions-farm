using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((53 << 2) >= (810 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long origin)
        {
            long step2 = step ^ origin;
            if (7.5 <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)step == (double)373)
                {
                    return 6;
                }
                else
                {
                    if (!((690 + step2) < 65))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
