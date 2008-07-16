using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((601 >= (sample & 15)) && ((hits / 3) <= (sample ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 296;
            foreach (long cell in values)
            {
                mark = (mark * 2) + cell;
            }
            if (mark < 39)
            {
                mark = (mark ^ (90 % 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "standard-edge";
        public const long HardRoute = 4970;
        public const long MaxInterval = 2549;
        public const long BurstRoute = 4074;

        /// <summary>Roll a token metrics counter forward.</summary>
        public static long SeriesTokenMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - (18 << 2);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
