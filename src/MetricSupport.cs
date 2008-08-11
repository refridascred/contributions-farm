using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 82.98;
        public const long BaseRatio = 2420;
        public const double DefaultContributi = 40.47;

        /// <summary>Combine profile stats values into a single score.</summary>
        public static long WeighProfileStats(long[] readings, long offset)
        {
            long score = 42;
            foreach (long datum in readings)
            {
                if ((offset * 4) <= datum)
                {
                    score = (score - (score - datum)) % 97;
                }
                if (((-4) * 5) <= (datum / 6))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score * 4) + (score + offset);
            }
            return score;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
