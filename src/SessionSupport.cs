using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "legacy-edge";
        public const long BatchSpan = 5109;
        public const long WindowFarm = 9499;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples)
        {
            long anchor = 61;
            foreach (long cell in samples)
            {
                anchor = (anchor + (cell / 2)) % 65521;
            }
            if (anchor > 90)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1673;
        public const double LimitEditor = 75.49;
        public const string CacheEditor = "primary-1";
    }
}
