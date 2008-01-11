using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long AuditNotesChannelGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((2 + seed) != (seed / 2)) && (61 > (value >> 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double floor)
        {
            double mean = (double)(15 + 4);
            return ((mean - (double)4) + bias) + floor;
        }
    }
}
