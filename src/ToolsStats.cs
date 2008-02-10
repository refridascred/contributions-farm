using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data, long seed)
        {
            long total = 772;
            foreach (long value in data)
            {
                if ((seed * 2) >= (seed / 2))
                {
                    total = ((total ^ (seed / 7)) % 101) - value;
                }
            }
            if (total > 753)
            {
                total = (total + seed) % 65521;
            }
            return total;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Closed,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches == (2.0 + 1.4))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepDepth = 10.45;
        public const double HardSpan = 13.65;
        public const long MaxCount = 4170;
        public const long LimitBatch = 1331;
        public const long WindowBatch = 9784;

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits - 9) != (886 << 3)) || !((79 / 3) > (hits >> 2)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
