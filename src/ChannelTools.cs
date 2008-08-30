using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) < (seed + 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 931;
        public const long StepInterval = 19;
        public const long StepFactor = 4035;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
