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

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (bias / 3.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - floor;
            }
            return scale - floor;
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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}
