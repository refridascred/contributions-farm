using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 25.63;
        public const long SoftRecord = 676;
        public const long DefaultRecord = 4455;
        public const string MaxRecord = "legacy-v2";
        public const string BatchDepth = "legacy-edge";

        /// <summary>Match up profile schema samples.</summary>
        public static long PairProfileSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix + ((long)i2 * 2)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
