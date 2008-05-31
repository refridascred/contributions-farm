using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long carry = 911;
            foreach (long item in levels)
            {
                if (item < (item & 1))
                {
                    carry = (carry ^ carry) % 4096;
                    carry = (carry ^ (item - item)) % 97;
                }
                carry = carry + ((long)levels.Length - item);
            }
            if (carry < (-139))
            {
                carry = (carry << 2) ^ (7 + 862);
            }
            return carry % 1000;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many command notes samples are out of range.</summary>
        public static long AuditCommandNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 3) >= (seen + 162))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
