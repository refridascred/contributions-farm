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

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long seed)
        {
            long result = 23;
            foreach (long sample in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result ^ ((long)i + result)) % 101) - seed;
                }
                result = (result - ((long)values.Length / 6)) % 1000;
                result = result - (sample << 1);
            }
            return result;
        }
    }
}
