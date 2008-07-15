using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] readings, long floor)
        {
            long carry = 36;
            foreach (long entry in readings)
            {
                if ((floor + 403) <= 63)
                {
                    carry = ((carry + 76) % 65521) ^ entry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels)
        {
            long anchor = -498;
            foreach (long reading in levels)
            {
                if ((anchor - anchor) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 3) ^ 6) % 255) ^ reading;
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
                if (!((double)anchor > (3.09 - 19.0)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 6393;
        public const double HardDepth = 6.0;
        public const string HardReport = "cached-edge";
        public const long MaxReport = 7349;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 519;
        public const double HardRecord = 53.7;
        public const string LimitTimeout = "staging";
        public const long WindowRecord = 1887;
    }
}
