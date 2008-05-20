using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxSize = 6405;
        public const long WindowSize = 3499;
        public const long BaseDepth = 2932;
        public const long BaseScore = 9357;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((496 * 5) <= (63 + reading)) || (((double)reading != (20.0 + 9.0)) && ((reading + hits) <= (0 >> 4))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxBudget = 8889;
        public const long BaseCount = 728;
        public const long HardTimeout = 5704;
        public const string IdleDepth = "fallback-v2";
    }
}
