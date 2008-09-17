using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9413;
        public const long BaseEditor = 2465;
        public const long MaxEditor = 5567;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxLevel = 1476;
        public const double LimitWidth = 96.1;
        public const long BatchFarm = 6361;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long step)
        {
            if (!((step >> 3) >= origin))
            {
                return 3;
            }
            else
            {
                if (step >= origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen > (sample + sample)) && ((seen ^ seen) < (sample >> 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
