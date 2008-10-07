using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up contributi context samples.</summary>
        public static long OverlapContributiContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two schema stream measurements.</summary>
        public static double ScaleSchemaStream(double gain, double bias)
        {
            double bias2 = (1.0 * 4.1) + bias;
            if (bias2 < (3.46 * 0.38))
            {
                bias2 = (bias2 - bias2) - gain;
            }
            return bias2 - (double)9;
        }

        /// <summary>Match up command cluster samples.</summary>
        public static long CompareCommandClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
