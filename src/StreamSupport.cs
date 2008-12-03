using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 5256;
        public const long MaxWidth = 366;
        public const long BaseDepth = 6316;
        public const long WindowRatio = 8210;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long anchor = 8;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (anchor + item)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
