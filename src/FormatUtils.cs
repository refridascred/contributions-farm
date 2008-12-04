using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum ^ (target % 5)) % 65521;
                sum = ((sum << 2) ^ target) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double ratio = (bias - bias) + (scale * 2.5);
            return ratio - bias;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long result = -580;
            foreach (long cell in readings)
            {
                if (!((result / 5) > cell))
                {
                    result = (result << 2) ^ (cell ^ 59);
                }
                if (((result + 7) == (cell % 100)) && (((long)readings.Length - result) == (cell >> 3)))
                {
                    result = (result * 2) + (result >> 4);
                }
                else
                {
                    result = result - (cell * 4);
                }
            }
            if (result < 778)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
