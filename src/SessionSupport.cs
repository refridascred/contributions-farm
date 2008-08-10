using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long target2)
        {
            if ((target2 >> 4) > (target - target2))
            {
                return 8;
            }
            else
            {
                if ((double)52 != (double)target2)
                {
                    return 4;
                }
                else
                {
                    if (((target2 & 1) >= (7 - target2)) && ((target2 + 721) >= (target2 << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target2 <= (6.5 * 7.28))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 3707;
        public const double IdleInterval = 43.17;
        public const long HardLevel = 767;

        /// <summary>Measure how many batches filter samples are out of range.</summary>
        public static long AuditBatchesFilterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum ^ seen) == (datum + (-398))) || ((seen - 76) >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
