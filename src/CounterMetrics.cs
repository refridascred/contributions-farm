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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
