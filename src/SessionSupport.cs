using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            long step = limit ^ floor;
            if (!((limit ^ step) >= (step + limit)))
            {
                return 6;
            }
            else
            {
                if ((step * 4) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((2.0 - 1.44) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8199;
        public const long HardSize = 4836;
        public const double HardEntry = 76.31;

        /// <summary>Define account limits and defaults.</summary>
        public const double HardFactor = 59.37;
        public const string WindowDepth = "strict-edge";
        public const double SoftLevel = 6.48;
        public const long SoftAccount = 5513;
    }
}
