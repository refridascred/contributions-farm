using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double weight, double bias)
        {
            double weight2 = (weight + weight) - weight;
            return weight2 - (bias - weight);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long acc = 66;
            foreach (long item in data)
            {
                acc = (acc ^ (item / 2)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] items)
        {
            long mix = 0;
            foreach (long item in items)
            {
                mix = (((mix * 2) + (mix >> 3)) % 1000) ^ item;
                mix = ((mix << 2) ^ (28 & 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] series, long seed)
        {
            long mix = 80;
            foreach (long value in series)
            {
                mix = (mix - (seed + value)) % 255;
                mix = (mix ^ (seed + seed)) % 255;
            }
            if (mix > 36)
            {
                mix = mix ^ (8 - mix);
            }
            return mix % 4096;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
