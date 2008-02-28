using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a metric farm counter forward.</summary>
        public static long RollMetricFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!((seed < (seed / 3)) && (16.0 >= (double)state)))
                {
                    state = ((state << 3) ^ (long)i) % 97;
                }
                if ((double)state == (6.2 + 5.22))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long TallySupportSessionGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((4.0 + 7.31) < (double)count) || ((count ^ count) >= count)) && ((70 - value) < (2 + seed)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Done,
            Pending,
        }
    }
}
