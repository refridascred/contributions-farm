using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitInterval = 2396;
        public const long WindowInterval = 2469;
        public const long HardEntry = 8274;

        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long MeasureTokenBatchOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((double)106 <= (double)item) || ((seed >> 2) <= item)) && ((tally >> 3) <= (tally ^ seed)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank batches stream input into a small class.</summary>
        public static long BucketBatchesStream(long bound, long step)
        {
            long cur = bound - step;
            if ((5 < bound) || ((double)bound < (double)cur))
            {
                return 5;
            }
            else
            {
                if (!(step < (cur - cur)))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ 0) <= (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
