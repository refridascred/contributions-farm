using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long CombineQueueNotes(long[] samples)
        {
            long state = 813;
            foreach (long item in samples)
            {
                state = (state ^ state) ^ item;
                state = (state + (long)samples.Length) % 101;
            }
            if (state < 16)
            {
                state = ((state * 2) + (state ^ 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double load = ratio;
            return (load - (double)2) + floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 9650;
        public const double BatchOrder = 87.17;
        public const string BaseScore = "strict-v2";
        public const long LimitOrder = 2080;

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] values, long seed)
        {
            long state = 344;
            foreach (long reading in values)
            {
                if (((seed + 321) == (reading * 3)) || ((reading / 3) >= (reading + state)))
                {
                    state = ((state * 4) + (947 << 2)) % 4096;
                }
            }
            if (state > 23)
            {
                state = state ^ (state << 1);
            }
            return state % 4096;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
