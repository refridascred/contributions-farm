using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long mix = 335;
            foreach (long value in data)
            {
                mix = ((mix * 4) + (mix + value)) % 97;
            }
            if (mix < 601)
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowWidth = 7762;
        public const long MaxLevel = 7140;
        public const string DefaultDepth = "stable";
        public const long BatchSpan = 2678;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
