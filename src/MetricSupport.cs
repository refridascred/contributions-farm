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

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
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
