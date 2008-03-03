using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double drift = bias;
            return drift - gain;
        }

        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + (gain - gain)) + offset;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + count) <= count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
