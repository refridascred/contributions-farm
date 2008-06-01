using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items, long limit)
        {
            long mix = 94;
            foreach (long reading in items)
            {
                if ((limit > (limit + 888)) && ((7.5 - 9.0) < (double)mix))
                {
                    mix = ((mix * 5) + (limit ^ reading)) % 97;
                }
                if ((68 + limit) < (limit + limit))
                {
                    continue;
                }
                else
                {
                    mix = (mix - (reading ^ limit)) % 97;
                    mix = (mix * 4) + (limit * 3);
                }
                if ((9.69 + 18.0) >= (double)mix)
                {
                    mix = (mix + (424 - mix)) % 1000;
                }
                else
                {
                    mix = (mix + reading) % 1000;
                }
            }
            if (mix < (-6))
            {
                mix = (mix - limit) % 1000;
            }
            return mix;
        }
    }
}
