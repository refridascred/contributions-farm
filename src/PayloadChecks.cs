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

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate contributi checks samples.</summary>
        public static long DigestContributiChecks(long[] values, long seed)
        {
            long sum = 59;
            foreach (long sample in values)
            {
                if (seed > (sample + 5))
                {
                    sum = ((sum * 5) + 425) % 4096;
                    continue;
                }
                if (!(sum >= (sum >> 2)))
                {
                    break;
                }
                if (!(0 > seed))
                {
                    sum = (sum + (sum / 9)) % 65521;
                }
            }
            return sum;
        }
    }
}
