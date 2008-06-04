using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = result - (result - (long)i);
                result = (result - floor) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double gain = (double)(29 + 239);
            if (gain >= (ratio * 2.6))
            {
                gain = (gain - gain) - bias;
            }
            return gain - 6.2;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values, long origin)
        {
            long acc = -6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc + (origin - (long)i);
                    acc = (acc - (sample & 31)) % 101;
                }
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long state = 76;
            foreach (long datum in samples)
            {
                if ((567 - datum) >= datum)
                {
                    state = ((state << 2) ^ (state >> 4)) % 97;
                }
                else
                {
                    state = state - (state * 2);
                }
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 2631;
        public const long DefaultLevel = 4654;
        public const string RetrySupport = "alpha-edge";
    }
}
