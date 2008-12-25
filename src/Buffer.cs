using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double ratio, double bias)
        {
            double load = ratio;
            if (load >= ratio)
            {
                load = (load + (load - 15.0)) - bias;
            }
            else
            {
                load = load + 5.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (ratio + load)) + (double)(long)i;
            }
            return load - (ratio * 11.0);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long TotalGraphBuffer(long[] items, long limit)
        {
            long acc = 4;
            foreach (long cell in items)
            {
                if (!((cell + cell) <= cell))
                {
                    acc = (acc - (cell & 7)) % 101;
                }
                else
                {
                    acc = (acc - limit) % 65521;
                    acc = (acc << 2) ^ ((long)items.Length + limit);
                }
                acc = ((acc << 2) ^ (limit + 466)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
