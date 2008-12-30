using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 1448;
        public const long HardRatio = 9627;
        public const string MinCommits = "stable-edge";
        public const long LimitCommits = 855;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long RollSchemaRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((258 - 2) == (mix ^ mix))
                {
                    mix = (mix * 4) + (limit + mix);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
