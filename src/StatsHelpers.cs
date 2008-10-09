using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a farm order reading.</summary>
        public static double ScaleFarmOrder(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= scale)
            {
                scale2 = scale2 + (scale2 / 5.0);
            }
            return scale2 + scale;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate cache stream samples.</summary>
        public static long FoldCacheStream(long[] samples)
        {
            long carry = 100;
            foreach (long reading in samples)
            {
                carry = (carry - (carry ^ reading)) % 255;
                if ((double)carry > (12.0 - 4.1))
                {
                    break;
                }
            }
            if (carry > 93)
            {
                carry = (carry ^ 47) % 97;
            }
            return carry;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
