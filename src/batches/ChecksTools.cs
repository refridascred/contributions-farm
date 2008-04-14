using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double weight = bias - (13.0 / 9.0);
            if (weight <= (weight - gain))
            {
                weight = weight - (4.06 / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of payload buffer readings.</summary>
        public static long TotalPayloadBuffer(long[] readings)
        {
            long carry = 8;
            foreach (long cell in readings)
            {
                carry = (((carry * 4) + carry) % 1000) - cell;
            }
            return carry % 65521;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double load = (double)(4 - 4);
            if (load < bias)
            {
                load = load - (load + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (offset + load)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }
    }
}
