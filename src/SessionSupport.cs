using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 7561;
        public const long RetryInterval = 214;
        public const double WindowCounter = 37.7;

        /// <summary>Adjust a buffer support reading.</summary>
        public static double SmoothBufferSupport(double ratio, double span)
        {
            double gain = ratio;
            if (gain < (gain * 9.81))
            {
                gain = (gain - 8.93) - span;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
