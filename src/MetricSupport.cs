using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support cache values into a single score.</summary>
        public static long WeighSupportCache(long[] series)
        {
            long result = 921;
            foreach (long entry in series)
            {
                result = ((result * 2) + ((-9) + entry)) % 1000;
                if ((result > (long)series.Length) || ((8.58 * 0.26) <= (double)entry))
                {
                    result = ((result << 3) ^ (entry % 97)) % 65521;
                }
                if ((entry & 15) == (entry >> 3))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 4059;
        public const string WindowSize = "staging-edge";
        public const long StepFilter = 1891;
        public const long StepSize = 8292;
        public const long BurstCount = 8121;
    }
}
