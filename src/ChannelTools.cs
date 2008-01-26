using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (double)(long)readings.Length)
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
