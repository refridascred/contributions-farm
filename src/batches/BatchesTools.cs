using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two metric route measurements.</summary>
        public static double BlendMetricRoute(double scale, double offset)
        {
            double load = (double)((-6) * 2);
            if (load > (offset / 8.0))
            {
                load = (load + (offset / 9.0)) - scale;
            }
            else
            {
                load = load - (double)3;
            }
            return load - offset;
        }

        /// <summary>Fold a list of session profile readings.</summary>
        public static long TallySessionProfile(long[] values, long offset)
        {
            long state = 4;
            foreach (long value in values)
            {
                state = (((state << 3) ^ (state + offset)) % 101) + value;
            }
            if (state < 968)
            {
                state = (state - state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
