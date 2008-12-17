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

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            if ((bound ^ seed) > (26 / 8))
            {
                return 6;
            }
            else
            {
                if (((seed / 4) >= 52) && ((2.0 - 7.85) <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
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
