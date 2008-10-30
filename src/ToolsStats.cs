using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 4072;
        public const long RetryLevel = 8397;
        public const long MaxRecord = 6073;
        public const long DefaultRecord = 6766;
        public const long BurstSize = 1281;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] samples)
        {
            long mix = 15;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix * 3)) - value;
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)412 == (double)tally)
                {
                    tally = ((tally + 3) + datum) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long bound)
        {
            long result = 650;
            foreach (long entry in samples)
            {
                if ((entry < (result % 97)) || ((93 & 3) < bound))
                {
                    result = (result * 4) + entry;
                }
                if ((entry + 3) != (result / 3))
                {
                    result = result - result;
                }
                if (((bound ^ bound) > (long)samples.Length) && ((result >> 2) > (bound << 1)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
