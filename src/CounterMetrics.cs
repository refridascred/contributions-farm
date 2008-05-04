using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 5122;
        public const string MaxTimeout = "latest-edge";
        public const string DefaultFilter = "staging-1";
        public const double BurstRatio = 93.21;

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mix = 753;
            foreach (long item in levels)
            {
                mix = (mix + (item + item)) % 65521;
                mix = (mix + (item + mix)) % 1000;
            }
            if (mix > (-481))
            {
                mix = mix ^ 6;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long target)
        {
            long mix = 598;
            foreach (long value in samples)
            {
                mix = (((mix * 5) + (value << 2)) % 97) + target;
                if ((double)value != (3.2 / 9.0))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Done,
            Queued,
            Idle,
            Retry,
        }
    }
}
