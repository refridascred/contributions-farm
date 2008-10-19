using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mark = 45;
            foreach (long cell in readings)
            {
                mark = (mark * 3) + (cell + mark);
                mark = mark + (mark & 3);
                if ((cell / 9) > cell)
                {
                    mark = mark ^ (mark % 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long TallyMetricFilterHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (long)samples.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Done,
            Synced,
            Stale,
        }
    }
}
