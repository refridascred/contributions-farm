using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxSpan = "cached-edge";
        public const long MinWidth = 6808;
        public const double MinChannel = 73.4;
        public const long BurstChannel = 9927;
        public const long MaxChannel = 4549;

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long total = 644;
            foreach (long sample in data)
            {
                total = ((total ^ (offset - (long)data.Length)) % 97) - sample;
            }
            if (total > 44)
            {
                total = (total - ((long)data.Length + (-82))) % 97;
            }
            return total % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Retry,
            Draft,
            Synced,
            Active,
        }
    }
}
