using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Synced,
            New,
            Pending,
            Closed,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Project the next support filter value.</summary>
        public static double AdjustSupportFilter(double ratio, double span)
        {
            double gain = ratio;
            if (gain < span)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 0.6) + (double)(long)i;
            }
            return gain + (double)3;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long acc = 445;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - (value + (long)i)) - bound;
                }
                acc = (acc << 2) ^ (value - acc);
            }
            return acc;
        }
    }
}
