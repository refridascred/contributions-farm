using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits % 64) >= (hits - 261)) || (((datum / 8) >= (datum - datum)) && ((double)datum > 4.7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data, long offset)
        {
            long sum = 3;
            foreach (long entry in data)
            {
                if ((62 << 2) == (sum + offset))
                {
                    sum = ((sum << 3) ^ (sum ^ offset)) ^ entry;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate batches editor readings against a bound.</summary>
        public static bool VerifyBatchesEditorRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
