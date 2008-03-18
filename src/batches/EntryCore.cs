using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next route payload value.</summary>
        public static double ProjectRoutePayload(double rate, double offset)
        {
            double rate2 = offset - (offset * 4.45);
            if (rate2 < (offset * 0.27))
            {
                rate2 = (rate2 + (rate2 * 8.31)) - rate;
            }
            return rate2 - (rate2 + rate2);
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a metric support sample.</summary>
        public static long LocateMetricSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Queued,
            Done,
            New,
            Retry,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (limit * 3)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
