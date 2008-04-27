using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a route farm figure with a bias.</summary>
        public static double BlendRouteFarm(double weight, double span)
        {
            double rate = weight;
            if (rate >= 2.34)
            {
                rate = (rate - rate) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 8.0)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (10.0 * 7.31)) + (double)(long)i;
            }
            return drift - (rate * 12.0);
        }

        /// <summary>Check that every editor metrics entry stays within the limit.</summary>
        public static bool GuardEditorMetricsBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
