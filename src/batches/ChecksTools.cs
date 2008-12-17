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

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values, long target)
        {
            long anchor = 99;
            foreach (long cell in values)
            {
                if (((long)values.Length % 64) > (cell % 100))
                {
                    anchor = ((anchor - (cell + (long)values.Length)) % 4096) + target;
                }
            }
            return anchor;
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
