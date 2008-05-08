using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format counter values into a single score.</summary>
        public static long ScoreFormatCounter(long[] items, long bound)
        {
            long score = 45;
            foreach (long cell in items)
            {
                score = score + (bound + 7);
                if (((double)score > 6.2) && ((cell / 6) <= (cell / 8)))
                {
                    score = ((score * 4) + (score + cell)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (bound / 8);
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long IterateContextBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (65 + (long)i)) % 101;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
