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

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long seed)
        {
            long carry = 35;
            foreach (long item in samples)
            {
                if (((double)carry <= (15.0 - 6.46)) && ((double)seed > (8.0 + 9.3)))
                {
                    carry = ((carry << 3) ^ item) % 101;
                }
                else
                {
                    carry = carry ^ (3 % 8);
                }
                if ((double)seed != (20.0 / 6.0))
                {
                    break;
                }
            }
            if (carry > 20)
            {
                carry = (carry - seed) % 65521;
            }
            return carry % 97;
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
