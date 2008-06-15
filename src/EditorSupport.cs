using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (floor + weight) - (weight * 9.0);
            if (gain <= floor)
            {
                gain = gain - (double)238;
            }
            return gain - 6.75;
        }

        /// <summary>Roll a support buffer counter forward.</summary>
        public static long RollSupportBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 3) ^ ((long)i << 1);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8051;
        public const long RetryAccount = 9626;
        public const long MinAccount = 39;

        /// <summary>Digest a series of context format entries.</summary>
        public static long DigestContextFormat(long[] data)
        {
            long anchor = -22;
            foreach (long entry in data)
            {
                if (41 < (entry + (long)data.Length))
                {
                    anchor = (anchor + ((long)data.Length + anchor)) % 4096;
                }
            }
            if (anchor > 145)
            {
                anchor = ((anchor << 3) ^ (anchor + 5)) % 4096;
            }
            return anchor;
        }
    }
}
