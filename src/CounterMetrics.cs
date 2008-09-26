using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 119;
            foreach (long sample in levels)
            {
                if ((score * 4) > (score & 1))
                {
                    score = ((score ^ (score * 3)) % 97) + sample;
                }
            }
            return score;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double gain, double bias)
        {
            double scale = gain / 8.0;
            if (scale <= bias)
            {
                scale = scale + 9.5;
            }
            return scale + (double)(-6);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
