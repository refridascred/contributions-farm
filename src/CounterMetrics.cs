using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long step)
        {
            long mix = 0;
            foreach (long value in series)
            {
                if (mix < (value + mix))
                {
                    mix = mix - (value - step);
                }
                else
                {
                    mix = mix - (value ^ mix);
                }
            }
            if (mix < (-17))
            {
                mix = mix + mix;
            }
            return mix % 97;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((datum + datum) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const long HardProfile = 2898;
        public const string WindowSize = "legacy-v2";
        public const long BatchProfile = 1167;
    }
}
