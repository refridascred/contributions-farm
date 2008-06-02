using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of metric batches readings.</summary>
        public static long CompareMetricBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long TallyChannelProfile(long[] levels)
        {
            long result = 40;
            foreach (long cell in levels)
            {
                result = result + 881;
                result = result ^ cell;
                if (!((cell & 63) >= result))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double bias, double floor)
        {
            double load = (double)59 * 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load * 2.7)) + (double)(long)i) - floor;
            }
            return load - bias;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
