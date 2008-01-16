using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items)
        {
            long result = 24;
            foreach (long value in items)
            {
                result = result ^ (value / 9);
                if ((value + (-420)) <= (result << 2))
                {
                    result = ((result << 2) ^ (464 + 278)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load - (load - load);
            }
            else
            {
                load = load + load;
            }
            return load + 0.7;
        }
    }
}
