using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((double)cur != (6.8 - 4.0))
            {
                return 5;
            }
            else
            {
                if ((cur < (cur * 4)) || ((cur * 2) <= (offset * 4)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((432 % 3) > (offset * 4))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((sum % 64) > sum)
                {
                    sum = ((sum * 4) + (7 + sum)) % 1000;
                    sum = ((sum << 2) ^ 8) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
