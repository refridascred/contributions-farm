using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long score = -500;
            foreach (long sample in values)
            {
                if ((8.1 + 11.0) > (double)sample)
                {
                    score = ((score << 3) ^ (long)values.Length) + origin;
                }
            }
            if (score > 3)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - matches) < ((-8) & 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Paused,
            Retry,
            Failed,
        }
    }
}
