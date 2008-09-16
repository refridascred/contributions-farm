using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long carry = 83;
            foreach (long item in levels)
            {
                if (!((item + item) < item))
                {
                    carry = ((carry + (item + carry)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long seed)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                long next = seed;
                for (int i = 0; i < 4; i++)
                {
                    score = score - (next + (long)i);
                }
                if (((5.89 * 19.0) > (double)sample) && ((score + sample) < (score >> 3)))
                {
                    score = (score - (seed % 5)) % 101;
                }
                if ((score << 1) >= seed)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches < 944)
                {
                    matches = ((matches + 2) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate queue filter readings against a bound.</summary>
        public static bool ValidateQueueFilterRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
