using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5973;
        public const long IdleRatio = 9525;
        public const long BurstInterval = 7244;
        public const long DefaultProfile = 1942;
        public const double CacheProfile = 67.97;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((6.2 / 3.0) != (double)target) && ((tally - target) >= (tally + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 954;
            foreach (long reading in samples)
            {
                if (((anchor / 5) < ((long)samples.Length + 339)) && (anchor <= (anchor + 798)))
                {
                    anchor = ((anchor << 3) ^ (reading ^ anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor / 2)) % 1000;
                }
            }
            return anchor;
        }
    }
}
