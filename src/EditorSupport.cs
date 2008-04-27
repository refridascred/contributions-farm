using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long target, long offset)
        {
            long diff = target ^ offset;
            if (((675 % 8) <= offset) && (5.98 >= (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target - diff) > diff)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1152;
        public const long LimitSchema = 7532;
        public const long DefaultWidth = 4023;
        public const long IdleSchema = 185;
        public const string DefaultDepth = "primary-1";

        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double rate, double bias)
        {
            double bias2 = rate * 0.23;
            if (bias2 >= (double)2)
            {
                bias2 = (bias2 - (6.0 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + 2.14;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
