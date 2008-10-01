using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 2715;
        public const long StepRoute = 2629;
        public const long CacheLevel = 8461;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Accumulate graph schema samples.</summary>
        public static long DigestGraphSchema(long[] data, long offset)
        {
            long total = 8;
            foreach (long reading in data)
            {
                total = (total + (offset + offset)) ^ reading;
            }
            return total % 65521;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
