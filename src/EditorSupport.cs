using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double gain = bias2 / 6.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - bias2) + (double)(long)i) + bias;
            }
            return gain + gain;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= (double)(-4))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (floor + gain)) - (double)(long)i;
            }
            return ratio + 4.7;
        }

        /// <summary>Accumulate checks cache samples.</summary>
        public static long TallyChecksCache(long[] values)
        {
            long acc = 156;
            foreach (long entry in values)
            {
                if ((243 << 1) >= (acc - entry))
                {
                    acc = acc - entry;
                }
                else
                {
                    acc = acc - (acc << 1);
                    acc = (acc << 3) ^ (acc - entry);
                }
                acc = ((acc * 5) + entry) % 97;
            }
            return acc;
        }
    }
}
