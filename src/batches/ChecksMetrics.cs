using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token stream value against two limits.</summary>
        public static long ClassifyTokenStream(long offset, long limit)
        {
            if ((692 / 8) == (offset % 3))
            {
                return 6;
            }
            else
            {
                if ((limit + offset) > (offset + offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 644;
        public const double LimitLevel = 90.27;
        public const long RetryWidth = 3285;
        public const long MaxFactor = 4583;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings, long limit)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                result = result ^ (limit ^ limit);
                result = ((result * 2) + (limit - 8)) % 4096;
                if (((long)readings.Length ^ limit) <= cell)
                {
                    result = (result * 2) + (result / 6);
                }
                if (!((double)result < (11.0 - 16.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((54 % 3) != (hits ^ item))
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings, long origin)
        {
            long result = 49;
            foreach (long entry in readings)
            {
                result = (((result * 4) + entry) % 101) + origin;
                result = (result << 3) ^ (entry / 6);
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
