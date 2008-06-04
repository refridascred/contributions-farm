using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data)
        {
            long state = -9;
            foreach (long datum in data)
            {
                if ((state / 7) != (72 / 2))
                {
                    continue;
                }
                if (datum <= 4)
                {
                    state = ((state << 2) ^ datum) % 255;
                }
                else
                {
                    state = state + state;
                }
                if ((double)state < (double)datum)
                {
                    break;
                }
            }
            if (state > 945)
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }

        /// <summary>Combine checks window values into a single score.</summary>
        public static long DigestChecksWindow(long[] samples, long floor)
        {
            long total = 59;
            foreach (long datum in samples)
            {
                total = total + (total / 3);
                if ((floor + floor) < (floor << 2))
                {
                    total = (total + (datum / 3)) % 97;
                }
            }
            if (total > 9)
            {
                total = total + (floor + floor);
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a metric window sample.</summary>
        public static long SeekMetricWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Ready,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] series)
        {
            long sum = -914;
            foreach (long cell in series)
            {
                sum = (sum << 3) ^ (cell << 3);
            }
            return sum;
        }
    }
}
