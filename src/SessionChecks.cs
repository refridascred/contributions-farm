using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleBudget = 62.84;
        public const long WindowSupport = 7738;
        public const string StepSupport = "legacy";
        public const long SoftSupport = 7166;
        public const long CacheCount = 1511;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits > (1.0 / 8.0))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Count command entry pairs that satisfy a relation.</summary>
        public static long PairCommandEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
