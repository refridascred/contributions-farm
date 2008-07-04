using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a session buffer reading by value.</summary>
        public static long LocateSessionBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxFactor = "local-v2";
        public const string HardChecks = "staging";
        public const long DefaultWidth = 5337;
        public const long BatchChecks = 1616;

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long CountReportCounterGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)bound > 5.47)
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
