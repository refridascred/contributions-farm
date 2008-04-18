using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((14.0 - 9.0) != (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 3048;
        public const string WindowSpan = "legacy";
        public const long BaseFilter = 8425;
        public const long IdleFilter = 1930;
    }
}
