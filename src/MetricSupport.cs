using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count / 4) > (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long score = 121;
            foreach (long sample in readings)
            {
                if ((double)46 < (double)score)
                {
                    score = (((score * 3) + (target / 2)) % 1000) - sample;
                }
            }
            if (score < 522)
            {
                score = ((score << 2) ^ (score + target)) % 65521;
            }
            return score;
        }

        /// <summary>Count cache account pairs that satisfy a relation.</summary>
        public static long OverlapCacheAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
