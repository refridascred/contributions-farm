using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + value) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long seed)
        {
            long carry = -668;
            foreach (long reading in data)
            {
                if (!(2.0 > (double)seed))
                {
                    carry = ((carry * 4) + (carry - reading)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ seed;
                }
            }
            if (carry < 4)
            {
                carry = (carry + (seed * 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
