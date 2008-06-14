using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data)
        {
            long anchor = 329;
            foreach (long value in data)
            {
                if (!((anchor % 12) != (value - value)))
                {
                    anchor = ((anchor * 3) + (anchor % 24)) % 4096;
                }
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor << 2) ^ (long)i;
                }
                anchor = anchor - (value + 838);
            }
            return anchor % 97;
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool VerifyGraphSupportBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double drift = (double)7 + 9.73;
            if (drift < (7.31 / 3.0))
            {
                drift = (drift - offset) + gain;
            }
            else
            {
                drift = drift + (double)(-15);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 1.5) + (double)(long)i;
            }
            return drift + (drift + 3.0);
        }
    }
}
