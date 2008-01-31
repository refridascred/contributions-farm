using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 283;
            foreach (long entry in series)
            {
                if (((double)result >= (9.0 - 20.0)) && ((double)entry != (double)251))
                {
                    result = (result - (entry * 5)) % 4096;
                }
            }
            if (result > 380)
            {
                result = (result + (34 * 3)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((12.0 * 3.7) == (double)step) && ((1.36 - 3.5) > (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Synced,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((42 >= (reading >> 2)) || ((matches + reading) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph checks readings.</summary>
        public static long TotalGraphChecks(long[] readings, long origin)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((carry + carry) > (carry % 64))
                {
                    carry = carry ^ (item % 7);
                }
            }
            if (carry < 4)
            {
                carry = ((carry << 3) ^ (origin + carry)) % 4096;
            }
            return carry;
        }
    }
}
