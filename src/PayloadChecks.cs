using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)seed > 9.7)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4951;
        public const long BaseLayout = 9830;
        public const double MaxLayout = 51.34;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long target)
        {
            long gap = origin + target;
            if ((gap % 24) > gap)
            {
                return 7;
            }
            else
            {
                if ((1 - gap) != (target - target))
                {
                    return 6;
                }
                else
                {
                    if (1 >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= (gap / 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double load = 7.0;
            if (load >= (0.96 / 6.0))
            {
                load = (load + (scale * 14.0)) - floor;
            }
            else
            {
                load = load - 5.68;
            }
            return load + (18.0 - scale);
        }
    }
}
