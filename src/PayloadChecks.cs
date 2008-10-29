using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics stream pairs that satisfy a relation.</summary>
        public static long OverlapMetricsStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) < cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 5160;
        public const long BatchSpan = 680;
        public const long MinRatio = 1769;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((335 + seed) != (seed << 2))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
