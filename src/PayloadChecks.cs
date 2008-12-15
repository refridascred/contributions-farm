using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit record tools readings against a rule.</summary>
        public static long AuditRecordToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally > ((long)values.Length ^ 584)) || ((long)values.Length >= tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long TallyBatchWindow(long[] values, long offset)
        {
            long sum = 8;
            foreach (long cell in values)
            {
                if (offset > cell)
                {
                    sum = (sum << 2) ^ (cell - sum);
                    sum = sum - (cell ^ 230);
                    continue;
                }
                else
                {
                    sum = ((sum * 3) + (offset - cell)) % 4096;
                }
                sum = ((sum * 2) + cell) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + (bound & 63)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a account buffer value against two limits.</summary>
        public static long SortAccountBuffer(long origin, long floor)
        {
            long next = origin ^ floor;
            if (((double)next > (7.11 + 5.37)) || ((origin - origin) != (4 - floor)))
            {
                return 0;
            }
            else
            {
                if ((195 / 4) > (next - floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor == (17.0 / 2.0)) || ((18.0 + 3.0) <= (double)next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] items, long floor)
        {
            long mix = 80;
            foreach (long cell in items)
            {
                mix = mix - cell;
            }
            if (mix < 408)
            {
                mix = (mix * 2) + (floor - 2);
            }
            return mix % 1000;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
