using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double bias = floor - (gain / 7.0);
            if (bias <= gain)
            {
                bias = bias - (6.31 - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 3.0) - (double)(long)i;
            }
            return bias + (bias - gain);
        }

        /// <summary>Digest a series of queue stats entries.</summary>
        public static long TallyQueueStats(long[] readings)
        {
            long anchor = 49;
            foreach (long value in readings)
            {
                if ((anchor - anchor) > (224 & 127))
                {
                    anchor = (anchor - (anchor >> 4)) - value;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 30) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = 368;
            foreach (long item in samples)
            {
                if ((total + total) > (total << 3))
                {
                    total = ((((total << 3) ^ total) % 97) + item) + target;
                }
            }
            return total;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Dropped,
            Stale,
        }
    }
}
