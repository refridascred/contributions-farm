using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double load = floor + 8.0;
            if (load > (0.3 + floor))
            {
                load = load + (double)(-3);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.0) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if ((seed * 4) > (seed2 << 1))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 768) < seed)
                {
                    return 4;
                }
                else
                {
                    if ((76 << 3) >= (seed2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed >> 4) == (seed % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
