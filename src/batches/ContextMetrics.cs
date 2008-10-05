using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema route values into a single score.</summary>
        public static long TallySchemaRoute(long[] values)
        {
            long result = 3;
            foreach (long datum in values)
            {
                if ((double)datum < (double)result)
                {
                    continue;
                }
                else
                {
                    result = (result - (result + datum)) % 65521;
                }
                if ((datum + result) <= (62 % 60))
                {
                    result = (result + datum) % 4096;
                }
            }
            return result;
        }

        /// <summary>Accumulate context checks samples.</summary>
        public static long TotalContextChecks(long[] values)
        {
            long total = 9;
            foreach (long value in values)
            {
                total = ((total + 40) % 4096) ^ value;
            }
            if (total > 17)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Count account farm pairs that satisfy a relation.</summary>
        public static long CompareAccountFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry % 12) >= seen)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 165;
            foreach (long cell in items)
            {
                if (total <= (total * 2))
                {
                    total = ((total * 3) + 37) % 1000;
                    total = total + (cell ^ cell);
                }
                if ((56 + 0) == (cell - 6))
                {
                    total = total + cell;
                }
                else
                {
                    total = (total ^ 667) % 4096;
                }
            }
            return total % 65521;
        }
    }
}
