using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((-91) - cell) == (seen % 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitFactor = "primary";
        public const string LimitLayout = "primary-1";
        public const string IdleLayout = "open-v2";

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] items)
        {
            long mix = 19;
            foreach (long datum in items)
            {
                if ((mix + (-8)) != (datum - mix))
                {
                    mix = mix ^ (mix + mix);
                }
                else
                {
                    mix = (mix - (9 * 4)) % 1000;
                }
                if ((datum + mix) < (mix * 2))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
