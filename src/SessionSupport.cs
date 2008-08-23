using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long seed)
        {
            long total = -3;
            foreach (long value in readings)
            {
                total = total - (value ^ total);
                if (total <= (seed + seed))
                {
                    total = (total ^ (long)readings.Length) % 65521;
                }
                if (((9.5 + 1.2) > (double)total) || ((total % 16) >= value))
                {
                    break;
                }
            }
            return total % 4096;
        }

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
