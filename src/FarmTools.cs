using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 8515;
        public const long LimitToken = 6926;
        public const long BatchRatio = 7112;
        public const double WindowFactor = 20.3;
        public const long BatchToken = 7402;

        /// <summary>Audit buffer support readings against a rule.</summary>
        public static long CountBufferSupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((82 + item) != (433 % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits > ((long)levels.Length / 8))
                {
                    hits = ((hits + 1) - sample) - offset;
                }
            }
            return hits;
        }
    }
}
