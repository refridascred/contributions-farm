using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value <= (double)74)
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
