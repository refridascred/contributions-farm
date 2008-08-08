using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double load = (double)528 + span;
            if (load >= (span - 6.78))
            {
                load = (load - load) - weight;
            }
            return load + (double)9;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                if (target > ((long)i ^ target))
                {
                    state = ((state * 3) + (state >> 5)) % 65521;
                }
                else
                {
                    state = (state ^ state) % 101;
                    state = ((state << 2) ^ (target + state)) % 101;
                }
                state = state - 678;
                if ((target % 10) >= (state & 7))
                {
                    state = (state + (long)i) % 65521;
                    continue;
                }
                else
                {
                    state = ((state << 3) ^ (state + target)) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double bias = (double)(758 + 694);
            if (bias >= bias)
            {
                bias = bias - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + (rate / 8.0);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
