using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double load = (bias2 / 7.0) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (bias2 * 1.37)) + (double)(long)i;
            }
            return load + (load - bias);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
