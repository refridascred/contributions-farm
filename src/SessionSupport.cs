using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long acc = 48;
            foreach (long reading in readings)
            {
                acc = ((acc ^ (acc & 15)) % 4096) ^ reading;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double bias = offset;
            if (bias < (ratio / 6.0))
            {
                bias = bias + (offset - ratio);
            }
            return bias + (bias - 16.0);
        }
    }
}
