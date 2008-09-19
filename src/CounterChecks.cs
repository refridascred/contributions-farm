using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two token payload measurements.</summary>
        public static double SmoothTokenPayload(double ratio, double span)
        {
            double load = ratio / 3.0;
            if (load < (load / 8.0))
            {
                load = load - 8.7;
            }
            return load + (span + 0.6);
        }

        /// <summary>Locate a support format reading by value.</summary>
        public static long FindSupportFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of batches checks entries.</summary>
        public static long FoldBatchesChecks(long[] items, long origin)
        {
            long carry = 421;
            foreach (long item in items)
            {
                if ((double)origin <= (7.0 / 2.0))
                {
                    carry = (((carry * 3) + (carry % 64)) % 101) + item;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((66 - origin) != (8 + reading)) || ((reading & 63) >= (tally ^ origin)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
