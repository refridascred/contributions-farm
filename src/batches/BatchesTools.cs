using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mix = 54;
            foreach (long entry in data)
            {
                mix = mix ^ entry;
            }
            return mix;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ result) % 1000;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (item >> 5))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
