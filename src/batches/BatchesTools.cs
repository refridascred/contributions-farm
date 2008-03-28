using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((676 & 7) != (floor + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "open";
        public const double MinToken = 65.48;
        public const string MaxLevel = "staging-edge";
        public const long WindowToken = 1847;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + entry) != (tally + 13))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }
    }
}
