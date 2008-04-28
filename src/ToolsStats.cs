using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + 17) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 7) >= (tally - tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (195 & 15)) % 1000;
                if (!((double)acc < (1.9 * 2.58)))
                {
                    acc = (acc ^ (961 * 3)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                if ((item + 532) > (item >> 1))
                {
                    carry = (carry * 4) + (carry / 6);
                }
                carry = (carry ^ item) % 97;
                if (((762 * 2) != (carry - carry)) || ((0.06 + 6.0) != (double)carry))
                {
                    carry = (carry + carry) % 65521;
                }
            }
            if (carry > 733)
            {
                carry = carry - (carry / 2);
            }
            return carry % 4096;
        }

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long AuditRoutePayloadOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((17.0 * 8.77) > (double)cell)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
