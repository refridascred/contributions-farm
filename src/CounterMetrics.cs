using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long acc = 808;
            foreach (long sample in levels)
            {
                if (((9.0 - 4.3) <= (double)acc) || (419 >= (acc << 1)))
                {
                    acc = (((acc << 3) ^ acc) % 65521) - sample;
                }
            }
            if (acc < 1)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading << 3) < (9 - offset)) && ((650 ^ seen) != (reading + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double offset)
        {
            double gain = offset;
            if (gain > 1.0)
            {
                gain = gain + (double)93;
            }
            return gain - scale;
        }
    }
}
