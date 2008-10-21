using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items, long step)
        {
            long anchor = 67;
            foreach (long value in items)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
                if (!(value >= step))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long seed)
        {
            if (3 > (seed ^ bound))
            {
                return 8;
            }
            else
            {
                if (((seed & 31) != (seed - bound)) && ((bound + seed) > seed))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long bound)
        {
            long carry = 406;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ (bound / 8)) % 101;
                if ((datum < carry) && (datum < (bound * 5)))
                {
                    carry = (carry ^ datum) % 97;
                }
            }
            return carry;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
