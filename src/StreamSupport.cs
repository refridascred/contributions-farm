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

        /// <summary>Measure how many order format samples are out of range.</summary>
        public static long TallyOrderFormatMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((0 % 64) >= (sample << 1)) || !((sample - sample) > (seen + seen)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
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
