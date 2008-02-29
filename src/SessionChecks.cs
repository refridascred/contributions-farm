using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = -1;
            foreach (long datum in values)
            {
                carry = carry + datum;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate route farm samples.</summary>
        public static long DigestRouteFarm(long[] values)
        {
            long total = -27;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (7 + item)) % 101;
                if (!((item - total) > (449 + item)))
                {
                    total = total ^ (total - item);
                }
                if ((double)item == (6.6 + 5.0))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 1)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double SmoothFilterEditor(double scale, double floor)
        {
            double weight = (double)(76 / 4);
            if (weight <= scale)
            {
                weight = (weight + weight) - floor;
            }
            return weight - scale;
        }
    }
}
