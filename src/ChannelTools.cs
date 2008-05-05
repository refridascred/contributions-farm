using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double load = offset * 12.0;
            if (load <= (offset * 10.0))
            {
                load = load - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 3.0)) + (double)(long)i;
            }
            return load + (double)492;
        }

        /// <summary>Match up cluster stats samples.</summary>
        public static long OverlapClusterStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Failed,
            Idle,
        }
    }
}
