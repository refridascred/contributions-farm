using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a account commits figure with a bias.</summary>
        public static double AdjustAccountCommits(double rate, double offset)
        {
            double weight = (double)(533 % 60);
            if (weight <= (offset / 6.0))
            {
                weight = (weight + (double)456) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (double)74) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
