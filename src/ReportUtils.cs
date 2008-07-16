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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 7;
            foreach (long datum in data)
            {
                if ((mix << 2) >= (42 << 2))
                {
                    mix = ((mix * 5) + 340) ^ datum;
                }
                else
                {
                    mix = ((mix * 5) + ((long)data.Length >> 1)) % 255;
                }
            }
            if (mix > (-6))
            {
                mix = mix - (6 & 1);
            }
            return mix;
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
