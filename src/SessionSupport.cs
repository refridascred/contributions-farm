using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 4003;
        public const string LimitBudget = "open-v2";
        public const long BaseSession = 7113;
        public const long DefaultFactor = 4842;
        public const long LimitSession = 4590;

        /// <summary>Rank batches profile input into a small class.</summary>
        public static long GradeBatchesProfile(long offset, long origin)
        {
            if ((origin ^ 354) != (offset / 8))
            {
                return 4;
            }
            else
            {
                if ((238 - offset) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset <= (2.8 - 2.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many stream schema samples are out of range.</summary>
        public static long MeasureStreamSchemaOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches == (9.93 + 0.8))
                {
                    matches = ((matches + 1) + item) + origin;
                }
            }
            return matches;
        }
    }
}
