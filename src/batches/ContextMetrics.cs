using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double drift = (ratio * 6.6) + (ratio * 1.21);
            if (drift <= bias)
            {
                drift = drift - (3.2 * 3.9);
            }
            else
            {
                drift = drift + 5.82;
            }
            return drift - (bias + ratio);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double floor)
        {
            double drift = (double)(691 & 127);
            if (drift <= 9.76)
            {
                drift = drift - (bias * 2.02);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + 1.6;
        }

        /// <summary>Combine filter schema values into a single score.</summary>
        public static long ScoreFilterSchema(long[] values)
        {
            long carry = 28;
            foreach (long datum in values)
            {
                if ((carry - carry) >= (carry + carry))
                {
                    carry = carry + (carry + datum);
                }
            }
            if (carry > 55)
            {
                carry = (carry + (carry >> 5)) % 65521;
            }
            return carry;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Paused,
            Idle,
            Locked,
        }
    }
}
