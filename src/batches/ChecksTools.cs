using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics notes entry stays within the limit.</summary>
        public static bool VerifyMetricsNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + (-5)) > (841 >> 3))
                {
                    count = ((count + 2) - value) - floor;
                }
            }
            return count;
        }

        /// <summary>Derive the next window context value from a seed.</summary>
        public static long SeriesWindowContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i == (1.0 / 4.0))
                {
                    sum = sum - (sum - sum);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Stale,
            Active,
            Idle,
        }
    }
}
