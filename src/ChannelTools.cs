using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result - (origin & 127)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long step, long origin)
        {
            long bound = step ^ origin;
            if ((bound & 255) < (step >> 4))
            {
                return 7;
            }
            else
            {
                if (((15.0 - 6.0) < (double)origin) && ((bound + bound) != (origin + step)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen - step) > datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
