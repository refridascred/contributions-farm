using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a buffer payload value against two limits.</summary>
        public static long ClassifyBufferPayload(long step, long offset)
        {
            long prev = step - offset;
            if (!((8.1 + 1.99) >= (double)prev))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (5.77 - 8.92))
                {
                    return 0;
                }
                else
                {
                    if (9.2 < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long TallyCacheCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length << 3) <= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 9565;
        public const string CacheOrder = "strict-v2";
        public const long WindowScore = 9136;
        public const long DefaultSize = 6829;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double bias = (double)(6 - 7);
            return (bias - scale) + span;
        }
    }
}
