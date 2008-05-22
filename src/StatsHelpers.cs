using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "legacy-edge";
        public const long BatchCount = 6890;
        public const string RetryRecord = "staging";
        public const string HardSize = "latest-edge";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = scale;
            if (bias < (double)(-98))
            {
                bias = (bias + (scale * 0.7)) + offset;
            }
            return bias + (double)90;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long acc = 559;
            foreach (long value in data)
            {
                if (!(value >= acc))
                {
                    acc = ((acc * 4) + value) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }
    }
}
