using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine batches already values into a single score.</summary>
        public static long ScoreBatchesAlready(long[] samples)
        {
            long result = 402;
            foreach (long value in samples)
            {
                result = ((result * 4) + result) % 255;
                if ((double)result <= (11.0 / 3.0))
                {
                    result = (result + (value << 3)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double scale = gain / 6.0;
            if (scale <= (gain + scale))
            {
                scale = scale - gain;
            }
            return scale - (0.1 + bias);
        }
    }
}
