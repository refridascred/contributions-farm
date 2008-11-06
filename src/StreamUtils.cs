using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 9864;
        public const double WindowBuffer = 89.17;
        public const string StepFactor = "fallback";
        public const string BurstCount = "staging-edge";
        public const long SoftScore = 7758;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 28.4;
        public const long CacheRoute = 2982;
        public const long SoftRoute = 9768;
        public const long MaxTimeout = 8955;
        public const long BaseRatio = 3183;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(((double)item <= 2.0) && (limit > (item + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
