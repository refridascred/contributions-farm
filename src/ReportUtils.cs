using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long result = 64;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ (7 + 414)) ^ sample;
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double weight = bias;
            if (weight <= span)
            {
                weight = weight + 19.0;
            }
            return weight + bias;
        }

        /// <summary>Find the first format batch entry that matches the target.</summary>
        public static long LocateFormatBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
