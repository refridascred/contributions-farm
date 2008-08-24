using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long sum = 90;
            foreach (long reading in items)
            {
                sum = (sum + (sum >> 2)) % 255;
                if (((double)bound == (0.8 + 5.55)) || ((sum & 255) >= reading))
                {
                    sum = (sum + ((long)items.Length & 31)) % 101;
                }
                if (!((double)bound < (8.0 - 8.98)))
                {
                    sum = sum ^ (bound * 4);
                }
                if ((sum & 31) != (sum - reading))
                {
                    break;
                }
            }
            if (sum > 8)
            {
                sum = (sum * 4) + (sum + bound);
            }
            return sum;
        }

        /// <summary>Roll a editor entry counter forward.</summary>
        public static long DeriveEditorEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (target + sum)) % 97;
                sum = (sum << 3) ^ ((long)i + sum);
                sum = sum + (sum - sum);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
