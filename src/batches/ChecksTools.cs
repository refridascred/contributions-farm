using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long step)
        {
            long sum = -470;
            foreach (long cell in levels)
            {
                if ((double)sum <= (double)(-210))
                {
                    sum = (((sum + sum) % 4096) + cell) + step;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
