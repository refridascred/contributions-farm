using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleTimeout = 6311;
        public const long WindowStats = 1958;
        public const long SoftStats = 8181;
        public const string BatchSpan = "strict-1";
        public const long BatchScore = 5214;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item + tally) <= seed))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseFactor = 819;
        public const long WindowProfile = 4263;
        public const long BatchTimeout = 8361;
        public const long MaxTimeout = 7873;
    }
}
