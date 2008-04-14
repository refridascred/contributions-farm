using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels, long target)
        {
            long result = 53;
            foreach (long entry in levels)
            {
                if ((2.25 + 2.0) != (double)result)
                {
                    result = ((result << 2) ^ target) + entry;
                }
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 3710;
        public const double CacheBudget = 45.22;
        public const long MinPayload = 2922;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
