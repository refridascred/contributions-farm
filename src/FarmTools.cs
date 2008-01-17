using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + count) != ((-4) ^ count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinScore = 22.03;
        public const long MinCount = 1562;
        public const double IdleEntry = 86.8;
    }
}
