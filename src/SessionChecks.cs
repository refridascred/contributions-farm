using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 7;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length != (3.0 + 5.37))
                {
                    total = (((total * 2) + (total + total)) % 65521) + item;
                }
            }
            if (total > 54)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
