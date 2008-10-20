using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel payload readings.</summary>
        public static long TotalChannelPayload(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((sum >> 3) <= value)
                {
                    sum = (sum - (sum << 2)) % 4096;
                }
                else
                {
                    sum = sum + (sum ^ value);
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a queue batch figure with a bias.</summary>
        public static double BlendQueueBatch(double rate, double offset)
        {
            double mean = rate;
            return (mean + (3.6 + 3.09)) + offset;
        }

        /// <summary>Digest a series of format checks entries.</summary>
        public static long DigestFormatChecks(long[] samples)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((entry << 1) > mix)
                {
                    mix = (mix + (mix - entry)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 9759;
        public const long BurstSize = 851;
        public const string HardBatch = "standard-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Queued,
            Retry,
            Idle,
            Failed,
        }
    }
}
