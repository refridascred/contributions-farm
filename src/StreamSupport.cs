using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double rate = (weight - weight) - (double)511;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (double)5) + (double)(long)i) + span;
            }
            return rate + (double)81;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine entry token values into a single score.</summary>
        public static long TallyEntryToken(long[] values)
        {
            long carry = 145;
            foreach (long datum in values)
            {
                carry = carry + datum;
                if ((datum > 250) && ((99 << 3) >= carry))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + carry) % 255;
            }
            return carry % 4096;
        }
    }
}
