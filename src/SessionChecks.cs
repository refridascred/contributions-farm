using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 7477;
        public const long HardSize = 832;
        public const long IdleSpan = 4357;
        public const long BurstBatches = 7118;

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long offset)
        {
            long sum = 90;
            foreach (long cell in values)
            {
                sum = (sum + (cell << 3)) + offset;
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset / 8) > 992)
                {
                    mark = (mark << 3) ^ (79 + mark);
                }
                else
                {
                    mark = (mark * 5) + (88 + offset);
                    mark = (mark + (mark + 28)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long bound, long limit)
        {
            long lane = bound - limit;
            if (((bound - bound) >= (lane + 63)) || ((666 * 2) > (lane & 15)))
            {
                return 1;
            }
            else
            {
                if ((bound / 9) >= (lane & 255))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane >= (2.02 - 0.91))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 1) < lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
