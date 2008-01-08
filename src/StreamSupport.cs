using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of checks payload entries.</summary>
        public static long TallyChecksPayload(long[] levels, long step)
        {
            long carry = 221;
            foreach (long entry in levels)
            {
                if ((1 + entry) < (step ^ entry))
                {
                    carry = ((carry * 5) + (entry >> 2)) % 97;
                }
                if (!((16.0 + 7.0) <= (double)entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 4) < 484)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double rate = (double)(97 - 672);
            if (rate >= 10.0)
            {
                rate = ((rate - (rate + 7.55)) + ratio) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate - 17.0;
        }
    }
}
