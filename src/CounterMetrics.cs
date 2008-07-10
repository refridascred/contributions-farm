using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                if (5.8 < (double)floor)
                {
                    acc = acc ^ (floor >> 3);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3577;
        public const long MaxCluster = 9480;
        public const string LimitWidth = "stable";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value << 2) <= value) || (((long)series.Length < value) || (seen < 689)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
