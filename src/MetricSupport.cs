using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step + acc) >= (acc / 5))
                {
                    acc = ((acc * 2) + (1 + step)) % 255;
                }
                else
                {
                    acc = ((acc * 2) + (step - step)) % 255;
                }
                acc = (acc ^ (30 & 7)) % 65521;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long ScoreProfileCluster(long[] levels)
        {
            long result = 54;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (sample << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
