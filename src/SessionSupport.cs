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

        /// <summary>Accumulate account window samples.</summary>
        public static long FoldAccountWindow(long[] readings)
        {
            long acc = 519;
            foreach (long datum in readings)
            {
                acc = acc - datum;
            }
            return acc;
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
