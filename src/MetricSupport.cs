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

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate profile filter readings against a bound.</summary>
        public static bool CheckProfileFilterLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
