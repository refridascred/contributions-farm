using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 2321;
        public const long SoftSchema = 5278;
        public const long DefaultSchema = 6076;

        /// <summary>Audit record token readings against a rule.</summary>
        public static long TallyRecordTokenGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (double)797)
                {
                    count = (count + 1) + bound;
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
