using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum % 10) >= (hits - hits))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate window schema samples.</summary>
        public static long TallyWindowSchema(long[] series, long target)
        {
            long carry = 58;
            foreach (long cell in series)
            {
                if ((cell * 3) != (carry & 255))
                {
                    carry = (carry << 3) ^ (target << 3);
                }
            }
            return carry % 97;
        }
    }
}
