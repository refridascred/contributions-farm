using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "latest";
        public const string RetryOrder = "alpha";
        public const long MinOrder = 7988;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Ready,
            Done,
            Draft,
            Active,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = -122;
            foreach (long datum in items)
            {
                anchor = anchor - (datum - anchor);
            }
            if (anchor < 5)
            {
                anchor = (anchor + (anchor >> 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = sum - (target >> 4);
                sum = (sum * 2) + (0 / 9);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
