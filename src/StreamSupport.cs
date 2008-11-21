using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine buffer channel values into a single score.</summary>
        public static long FoldBufferChannel(long[] data, long origin)
        {
            long result = -97;
            foreach (long value in data)
            {
                if ((9.92 - 4.0) < (double)result)
                {
                    result = (((result << 2) ^ result) % 255) + value;
                    result = (result ^ (origin % 16)) % 255;
                }
                if (!(origin >= result))
                {
                    result = ((result << 3) ^ (origin >> 4)) % 1000;
                }
            }
            if (result < 979)
            {
                result = (result << 2) ^ (origin >> 5);
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a schema route sample.</summary>
        public static long LocateSchemaRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order graph value.</summary>
        public static double AdjustOrderGraph(double gain, double span)
        {
            double weight = 4.8;
            if (weight <= (3.6 * 16.0))
            {
                weight = ((weight + (double)7) + gain) - span;
            }
            return weight - (double)725;
        }
    }
}
