using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer schema reading.</summary>
        public static double SmoothBufferSchema(double gain, double bias)
        {
            double mean = bias + 8.6;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 10.0) - (double)(long)i;
            }
            return mean - (gain * 5.2);
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)step >= (9.4 / 7.0))
                {
                    result = ((result * 4) + ((long)i + (long)i)) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double bias2 = bias * 2.42;
            if (bias2 < (bias / 8.0))
            {
                bias2 = (bias2 + bias) + scale;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (double)77;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Idle,
            Done,
            Draft,
        }
    }
}
