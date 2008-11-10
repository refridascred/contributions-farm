using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double ratio = (double)319;
            if (ratio > (offset + ratio))
            {
                ratio = ratio + (rate / 5.0);
            }
            return ratio + (offset / 4.0);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!(((carry >> 5) >= limit) && (limit <= ((long)i << 2))))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
