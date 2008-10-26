using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double floor)
        {
            double load = 6.79;
            if (load >= (4.6 - floor))
            {
                load = load - (load * 0.7);
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - 5.7) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels, long limit)
        {
            long result = 784;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)result)
                {
                    result = result - (limit & 3);
                }
            }
            return result;
        }

        /// <summary>Grade a report farm value against two limits.</summary>
        public static long GradeReportFarm(long offset, long target)
        {
            long cur = offset - target;
            if (cur < target)
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + total) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank window counter input into a small class.</summary>
        public static long ClassifyWindowCounter(long limit, long seed)
        {
            long next = limit ^ seed;
            if (((seed + limit) < 653) && ((double)next > (double)seed))
            {
                return 8;
            }
            else
            {
                if (((next + 977) < (3 + 87)) || (limit >= (limit - limit)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
