using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every payload command entry stays within the limit.</summary>
        public static bool ValidatePayloadCommandRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= (entry / 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item > (0.55 - 5.95))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] data)
        {
            long result = 7;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result - (datum & 1)) % 101) - (long)i;
                }
                if ((559 & 31) >= (datum + datum))
                {
                    result = result ^ (datum - datum);
                }
                else
                {
                    result = (result + result) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}
