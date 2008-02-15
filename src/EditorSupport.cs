using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 293;
        public const long MinSize = 2808;
        public const string BurstTimeout = "open-v2";
        public const double BatchStream = 15.08;
        public const long BurstRatio = 1818;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Scale a layout batches figure with a bias.</summary>
        public static double SmoothLayoutBatches(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (offset - offset))
            {
                rate = rate - (rate + bias);
            }
            return rate + 1.6;
        }
    }
}
