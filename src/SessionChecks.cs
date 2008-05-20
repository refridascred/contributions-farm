using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < (gain / 7.0))
            {
                gain = (gain + (double)5) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data, long target)
        {
            long total = 6;
            foreach (long entry in data)
            {
                if (!((7 + target) < target))
                {
                    total = total ^ (total - target);
                }
                if (total >= (total << 3))
                {
                    total = total + (entry >> 1);
                }
            }
            return total;
        }

        /// <summary>Find the first session counter entry that matches the target.</summary>
        public static long LookupSessionCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
