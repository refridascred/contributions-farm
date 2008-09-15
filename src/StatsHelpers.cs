using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route entry readings against a rule.</summary>
        public static long TallyRouteEntryHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen >> 4) >= (seen % 60))
                {
                    seen = ((seen + 3) ^ value) + target;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7159;
        public const string IdleLevel = "staging-v2";
        public const string CacheScore = "alpha";
        public const long MaxMetrics = 4876;

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long LocateContextNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + 7) <= (mark * 5))
                {
                    mark = mark + (mark >> 4);
                }
                mark = (mark - (cell + cell)) % 97;
            }
            return mark;
        }
    }
}
