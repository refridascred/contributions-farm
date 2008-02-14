using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ sum) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long AuditCommitsRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + item) <= (item * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
