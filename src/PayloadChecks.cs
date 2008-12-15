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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a queue profile value against two limits.</summary>
        public static long RankQueueProfile(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (((8.11 + 9.35) < (double)offset) || (offset2 > (offset3 + offset2)))
            {
                return 6;
            }
            else
            {
                if ((double)offset2 != (10.0 + 7.0))
                {
                    return 8;
                }
                else
                {
                    if (((offset3 << 1) > offset) && ((double)offset >= (3.2 / 8.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 7) <= (offset2 + offset3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
