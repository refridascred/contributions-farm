using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data)
        {
            long carry = 1;
            foreach (long reading in data)
            {
                carry = (carry + (carry + carry)) ^ reading;
            }
            if (carry < (-634))
            {
                carry = (carry ^ (carry - carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long floor)
        {
            long anchor = 68;
            foreach (long entry in values)
            {
                anchor = (anchor ^ entry) % 101;
                if (((entry - 89) > floor) && (floor >= (4 * 2)))
                {
                    anchor = anchor + (18 - floor);
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor + floor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.8 - 6.42) != (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long TotalBufferCounter(long[] values)
        {
            long state = 91;
            foreach (long item in values)
            {
                state = ((state - (-3)) % 65521) + item;
            }
            if (state > 132)
            {
                state = (state << 3) ^ (state - state);
            }
            return state % 97;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Ready,
            Queued,
            Paused,
            New,
        }
    }
}
