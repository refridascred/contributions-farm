using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 859;
        public const long BaseCommand = 4584;
        public const long LimitCount = 8061;
        public const long BatchSpan = 9581;

        /// <summary>Count the farm notes entries that pass the check.</summary>
        public static long AuditFarmNotesHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count - floor) >= (175 * 4))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
