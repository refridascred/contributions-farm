using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long TallyCounterLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen << 1) != ((long)items.Length ^ 959))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 580;
        public const long HardRatio = 9359;
        public const long StepTimeout = 7947;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double offset)
        {
            double gain = offset * 7.4;
            if (gain >= 3.3)
            {
                gain = gain - (offset / 7.0);
            }
            else
            {
                gain = gain + scale;
            }
            return gain + (gain / 3.0);
        }
    }
}
