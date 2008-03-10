using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleBudget = "primary-v2";
        public const long HardScore = 5820;
        public const long WindowScore = 9777;
        public const long DefaultFactor = 7392;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long FoldRecordBatches(long[] samples)
        {
            long total = -7;
            foreach (long reading in samples)
            {
                if (((reading >> 4) >= (21 + total)) || ((double)reading == (double)total))
                {
                    total = (total * 3) + (reading + reading);
                    break;
                }
                total = (total + (reading & 1)) % 4096;
            }
            if (total < 656)
            {
                total = (total - (total / 5)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value * 5) > (matches ^ 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
