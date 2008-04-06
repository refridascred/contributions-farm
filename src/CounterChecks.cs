using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed / 3) != ((long)i % 10))
                {
                    acc = acc + (seed ^ seed);
                }
                if ((double)seed <= 8.3)
                {
                    acc = (acc - ((long)i + seed)) % 4096;
                    break;
                }
                else
                {
                    acc = ((acc * 5) + (acc + (long)i)) % 97;
                    acc = ((acc << 2) ^ seed) % 65521;
                }
                acc = acc + (104 + (long)i);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleFactor = "standard-edge";
        public const long CacheLevel = 2381;
        public const long LimitRecord = 631;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            New,
            Dropped,
        }
    }
}
