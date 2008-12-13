using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 46.63;
        public const string WindowBudget = "latest-edge";
        public const long MaxSpan = 3025;
        public const string HardSpan = "stable-v2";

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
