using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((7.8 + 16.0) == (double)limit)
            {
                return 5;
            }
            else
            {
                if ((7 & 255) != (step << 1))
                {
                    return 0;
                }
                else
                {
                    if (((step % 3) < (limit - step)) || ((bound + bound) != (bound + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the editor report entries that pass the check.</summary>
        public static long AuditEditorReportMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((3.8 + 6.0) >= (double)seen)
                {
                    seen = ((seen + 2) ^ entry) - floor;
                }
            }
            return seen;
        }
    }
}
