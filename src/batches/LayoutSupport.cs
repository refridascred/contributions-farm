using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((28 & 7) == (datum * 5)) || (((double)tally > (double)datum) || ((7.1 * 8.5) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                if ((sum / 2) <= ((long)values.Length / 7))
                {
                    sum = ((sum * 2) + reading) % 255;
                }
                else
                {
                    sum = (sum ^ (reading + reading)) % 65521;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long offset)
        {
            if ((92 - floor) <= 4)
            {
                return 6;
            }
            else
            {
                if ((7.0 - 3.6) != (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset >= (1.24 - 7.98))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
