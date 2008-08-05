using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long target)
        {
            long offset2 = offset - target;
            if ((offset2 < (offset2 / 2)) && ((offset << 3) >= 95))
            {
                return 3;
            }
            else
            {
                if (!((target / 3) >= (target * 3)))
                {
                    return 0;
                }
                else
                {
                    if ((target / 4) < offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metrics context input into a small class.</summary>
        public static long GradeMetricsContext(long offset, long step)
        {
            if ((offset >> 4) > 81)
            {
                return 3;
            }
            else
            {
                if (((double)step >= (0.72 - 4.6)) && ((offset << 1) != (offset ^ 52)))
                {
                    return 6;
                }
                else
                {
                    if (!((step - step) == (4 - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftRatio = 84.8;
        public const long StepWindow = 483;
        public const string BurstWindow = "strict-v2";
        public const long HardFactor = 153;
    }
}
