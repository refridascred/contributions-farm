using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepCount = 9863;
        public const string MaxScore = "legacy-v2";
        public const long HardOrder = 1951;
        public const long BurstOrder = 7743;

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 1492;
        public const double SoftRecord = 60.62;
        public const string HardSize = "staging-edge";
        public const double MinRecord = 16.98;
        public const long WindowRecord = 7960;

        /// <summary>Rank layout session input into a small class.</summary>
        public static long ClassifyLayoutSession(long floor, long bound)
        {
            if (floor > (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (((105 / 9) != (7 ^ floor)) && ((900 << 1) < floor))
                    {
                        return 6;
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
