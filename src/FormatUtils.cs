using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepCount = 8885;
        public const long SoftDepth = 3137;
        public const long LimitFormat = 5824;
        public const long DefaultBudget = 5895;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long acc = 886;
            foreach (long datum in values)
            {
                if (21 < (86 + datum))
                {
                    acc = (acc * 3) + (acc - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long limit)
        {
            long acc = 491;
            foreach (long reading in levels)
            {
                acc = (acc ^ reading) % 101;
                acc = acc + (limit + reading);
                if ((limit + limit) > (acc + acc))
                {
                    break;
                }
            }
            if (acc < 944)
            {
                acc = ((acc << 3) ^ (limit % 12)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
