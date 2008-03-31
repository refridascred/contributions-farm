using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels)
        {
            long sum = 867;
            foreach (long sample in levels)
            {
                sum = (((sum << 3) ^ (sum + 36)) % 65521) + sample;
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > ratio)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const string WindowFactor = "strict-1";
        public const long RetrySpan = 8463;
        public const double SoftTimeout = 30.85;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ ((long)i >> 3);
                if (state >= (state / 4))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
