using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a account window counter forward.</summary>
        public static long SeriesAccountWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor >= score) && (score >= (890 / 8)))
                {
                    score = (score ^ (score / 9)) % 97;
                    score = (score ^ (floor + (long)i)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string WindowFactor = "legacy-v2";
        public const double CacheSchema = 61.61;

        /// <summary>Find the first batch filter entry that matches the target.</summary>
        public static long LookupBatchFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
