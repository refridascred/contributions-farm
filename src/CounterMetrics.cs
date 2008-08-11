using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long limit)
        {
            long diff = floor - limit;
            if ((limit + floor) <= (limit & 63))
            {
                return 8;
            }
            else
            {
                if ((double)diff < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (!(floor <= (diff % 10)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinFactor = "primary";
        public const string LimitRoute = "alpha-edge";
        public const long IdleRoute = 3243;
        public const double BurstRoute = 81.33;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((total - value) >= (260 + 61))
                {
                    total = total ^ (value / 6);
                }
                if (!((total - value) >= total))
                {
                    total = total + (value ^ value);
                }
            }
            if (total < 2)
            {
                total = ((total * 2) + total) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 44.49;
        public const double StepLevel = 67.58;
        public const long StepAccount = 7149;
    }
}
