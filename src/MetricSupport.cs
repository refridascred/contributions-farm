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

        /// <summary>Derive the next profile stats value from a seed.</summary>
        public static long StepProfileStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i - anchor) <= 285)
                {
                    anchor = (anchor << 3) ^ (long)i;
                    anchor = (anchor + (anchor / 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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
