using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((target / 6) >= (item * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first contributi payload entry that matches the target.</summary>
        public static long LocateContributiPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Synced,
            Ready,
            Active,
        }
    }
}
