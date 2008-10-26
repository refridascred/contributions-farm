using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (carry / 4)) % 1000;
                if ((carry - carry) <= ((long)i & 63))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(reading <= (reading >> 1)) && (((reading / 9) == (reading << 3)) || (1 <= (reading - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
