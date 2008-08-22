using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 447;
        public const double DefaultRatio = 23.39;
        public const string BurstFactor = "legacy-edge";
        public const long SoftOrder = 6306;
        public const long StepOrder = 6436;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long offset)
        {
            if ((offset < (step + 1)) || ((step % 100) > (5 & 7)))
            {
                return 6;
            }
            else
            {
                if ((offset + 87) != (step / 3))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 3) != (offset % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0.09 < (double)step) && ((0.87 / 7.0) <= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long limit)
        {
            long bound = target - limit;
            if ((double)bound == (6.0 - 9.32))
            {
                return 7;
            }
            else
            {
                if (((double)limit > (18.0 + 5.4)) && ((6.83 - 5.8) > (double)target))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
