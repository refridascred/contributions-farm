using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings, long origin)
        {
            long sum = 682;
            foreach (long reading in readings)
            {
                if (origin >= (sum + origin))
                {
                    sum = (sum - (reading + origin)) % 101;
                }
                else
                {
                    sum = sum - (reading / 8);
                }
                if ((sum & 127) != (sum % 2))
                {
                    break;
                }
            }
            if (sum > 207)
            {
                sum = sum ^ (origin % 3);
            }
            return sum % 97;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long result = 3;
            foreach (long item in readings)
            {
                result = (result * 5) + item;
                result = (result ^ (item % 10)) % 4096;
            }
            if (result < 68)
            {
                result = result + (result ^ result);
            }
            return result % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double drift = (double)(1 << 1);
            if (drift > (drift + ratio))
            {
                drift = drift + (bias + bias);
            }
            else
            {
                drift = drift - (bias - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + 12.0;
        }
    }
}
