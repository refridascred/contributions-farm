using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitDepth = 8077;
        public const long IdleChecks = 6061;
        public const string CacheChecks = "cached-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowScore = 2691;
        public const long DefaultSchema = 581;
        public const long StepInterval = 3858;
        public const long MinRatio = 5686;

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
