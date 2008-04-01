using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of queue channel readings.</summary>
        public static long WeighQueueChannel(long[] levels, long target)
        {
            long carry = 57;
            foreach (long entry in levels)
            {
                carry = (carry ^ (target % 12)) % 101;
                if (carry <= (entry - carry))
                {
                    carry = (carry * 5) + 57;
                }
                else
                {
                    carry = (carry + (entry + target)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally <= (3.9 / 3.0))
                {
                    tally = ((tally + 3) + value) + step;
                }
            }
            return tally;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
