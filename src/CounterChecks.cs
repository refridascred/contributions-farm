using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next order account value from a seed.</summary>
        public static long RollOrderAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + result) % 97;
                result = ((result << 3) ^ ((long)i + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings)
        {
            long sum = 143;
            foreach (long value in readings)
            {
                sum = (((sum * 3) + sum) % 65521) ^ value;
            }
            return sum;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long TallySessionFormatMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)origin <= (6.6 + 0.72))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster already samples are out of range.</summary>
        public static long TallyClusterAlreadyMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + seed) == (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading ^ reading) <= (reading + seen)) && (((double)origin > (20.0 - 0.1)) && (((long)data.Length + 34) != (origin >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Stale,
            New,
            Dropped,
        }
    }
}
