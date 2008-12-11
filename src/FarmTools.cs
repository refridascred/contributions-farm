using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long anchor = 91;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ anchor) % 1000) ^ entry;
            }
            return anchor;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (origin * 2)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
