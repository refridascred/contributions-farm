using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i == (double)offset) && ((double)(long)i == (7.0 - 16.0)))
                {
                    result = (result << 2) ^ (offset + offset);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank token order input into a small class.</summary>
        public static long GradeTokenOrder(long floor, long seed)
        {
            if ((double)seed >= (double)486)
            {
                return 6;
            }
            else
            {
                if ((seed % 8) < (seed * 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream batch readings against a rule.</summary>
        public static long AuditStreamBatchHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!!(item > (item + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
