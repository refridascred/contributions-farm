using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session order samples are out of range.</summary>
        public static long MeasureSessionOrderOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)seed > (3.0 * 6.65))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Idle,
            Stale,
            New,
            Locked,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long step)
        {
            long carry = -150;
            foreach (long reading in series)
            {
                carry = (carry ^ carry) ^ reading;
            }
            if (carry > 789)
            {
                carry = (carry + (step >> 4)) % 65521;
            }
            return carry;
        }
    }
}
