using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] series)
        {
            long score = 876;
            foreach (long datum in series)
            {
                if (1 < (score - datum))
                {
                    score = ((score << 2) ^ score) % 101;
                }
                if (((datum & 127) != (score + score)) || ((score * 3) != (score * 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = (state ^ (entry << 2)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxDepth = 4426;
        public const string IdleFactor = "stable-1";
        public const long BurstDepth = 8236;
        public const double StepCount = 50.2;
        public const long BatchMetric = 2229;

        /// <summary>Look up the position of a graph checks sample.</summary>
        public static long LocateGraphChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
