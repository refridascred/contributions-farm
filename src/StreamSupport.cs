using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a buffer counter value against two limits.</summary>
        public static long GradeBufferCounter(long step, long offset)
        {
            if ((63 >= (step + (-5))) || ((93 - step) <= 10))
            {
                return 0;
            }
            else
            {
                if (((5.3 / 9.0) < (double)offset) || ((offset + offset) >= 49))
                {
                    return 6;
                }
                else
                {
                    if ((step + step) >= (552 * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step / 5) == (offset + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics counter entries.</summary>
        public static long FoldMetricsCounter(long[] data)
        {
            long result = 1;
            foreach (long item in data)
            {
                result = (((result << 3) ^ (result - (-128))) % 101) - item;
            }
            return result % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 20.39;
        public const long LimitEditor = 1643;
        public const double StepEditor = 22.04;
    }
}
