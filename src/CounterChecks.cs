using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Paused,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double ratio = span;
            if (ratio >= (double)8)
            {
                ratio = (ratio + ratio) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (span * 8.5);
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values, long offset)
        {
            long carry = 147;
            foreach (long datum in values)
            {
                if ((carry % 3) >= (6 + carry))
                {
                    carry = carry - (carry + offset);
                }
                if (!((datum + carry) > (9 * 5)))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
            }
            if (carry > 42)
            {
                carry = (carry * 4) + ((long)values.Length & 3);
            }
            return carry;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
