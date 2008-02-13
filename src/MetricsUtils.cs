using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 2) ^ (carry / 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((2 & 7) > (limit ^ limit))
            {
                return 7;
            }
            else
            {
                if ((origin + 570) != (origin / 9))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (12.0 * 9.55))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of order buffer entries.</summary>
        public static long TotalOrderBuffer(long[] readings, long target)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = ((total ^ (target ^ 7)) % 97) + cell;
            }
            return total;
        }
    }
}
