using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long target)
        {
            if ((target + step) >= (step / 8))
            {
                return 3;
            }
            else
            {
                if (target < (step * 4))
                {
                    return 0;
                }
                else
                {
                    if ((target - target) > (3 - 77))
                    {
                        return 1;
                    }
                    else
                    {
                        if (14 <= (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Synced,
            Idle,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long origin2)
        {
            if (!((origin2 / 3) > (origin2 ^ origin2)))
            {
                return 2;
            }
            else
            {
                if (((-9) / 9) == (origin2 ^ origin2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double scale = 18.0;
            if (scale >= bias2)
            {
                scale = (scale - (double)(-8)) - bias;
            }
            else
            {
                scale = scale + (5.8 + bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)5;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Paused,
            Synced,
            New,
        }
    }
}
