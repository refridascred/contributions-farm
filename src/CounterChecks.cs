using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 12.19;
        public const long IdleRecord = 4319;
        public const long SoftDepth = 5363;

        /// <summary>Measure how many account contributi samples are out of range.</summary>
        public static long TallyAccountContributiMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((seed ^ hits) <= (hits * 5))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every batch session entry stays within the limit.</summary>
        public static bool CheckBatchSessionBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long DeriveBufferRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
