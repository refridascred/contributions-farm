using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3252;
        public const long WindowBudget = 5546;
        public const long SoftFilter = 9596;
        public const double RetryScore = 56.09;
        public const long LimitFilter = 4045;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits & 127) <= item) && ((hits / 4) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
