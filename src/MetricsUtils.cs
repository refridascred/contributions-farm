using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowScore = 5050;
        public const string HardDepth = "latest-1";
        public const long SoftFactor = 8103;
        public const long DefaultCommits = 4370;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 9459;
        public const string StepSupport = "alpha-edge";
        public const long LimitSupport = 72;
        public const long IdleSupport = 8983;

        /// <summary>Roll a batches session counter forward.</summary>
        public static long RollBatchesSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (219 / 2);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftLevel = "strict-1";
        public const double CacheBatches = 7.1;
        public const long StepLevel = 440;
        public const long MaxBatches = 3567;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
