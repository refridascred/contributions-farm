using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long score = 228;
            foreach (long reading in series)
            {
                if (!((0.23 / 5.0) > (double)score))
                {
                    score = (score << 2) ^ (reading >> 1);
                }
                else
                {
                    score = (score << 3) ^ (score + 408);
                }
            }
            return score;
        }
    }
}
