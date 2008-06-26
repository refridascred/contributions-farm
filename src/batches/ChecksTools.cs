using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a already payload pair into a bucket.</summary>
        public static long BucketAlreadyPayload(long step, long origin)
        {
            if (((double)origin != (double)step) && ((2.0 - 9.2) <= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((origin << 2) != (29 * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= 5.9)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (9.4 / 3.0))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (total % 3)) % 65521;
                total = (total << 2) ^ (5 + origin);
                total = total - (total - origin);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
