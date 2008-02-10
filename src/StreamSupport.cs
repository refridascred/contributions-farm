using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowCount = 26.28;
        public const long WindowProfile = 6645;
        public const string StepInterval = "alpha-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6221;
        public const long MinGraph = 4968;
        public const double MaxGraph = 48.52;

        /// <summary>Measure how many farm already samples are out of range.</summary>
        public static long TallyFarmAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
