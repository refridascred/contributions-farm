using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ (total + total)) % 97;
                total = (total + (origin * 4)) % 97;
                if ((origin >> 3) >= origin)
                {
                    break;
                }
                else
                {
                    total = (total + (869 ^ origin)) % 97;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a payload support counter forward.</summary>
        public static long IteratePayloadSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total ^ 60) % 255;
                if (!((634 & 127) > (total & 7)))
                {
                    total = (total << 3) ^ step;
                }
                total = ((total << 2) ^ (599 - 660)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
