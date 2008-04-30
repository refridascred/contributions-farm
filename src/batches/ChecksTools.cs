using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long score = 134;
            foreach (long entry in items)
            {
                if ((2.35 / 6.0) > (double)score)
                {
                    score = ((score - (limit << 1)) % 97) - entry;
                }
                if (!((long)items.Length < (limit << 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Locate a queue metrics reading by value.</summary>
        public static long SeekQueueMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command order readings against a bound.</summary>
        public static bool GuardCommandOrderRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
