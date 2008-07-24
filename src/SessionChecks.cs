using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile report pair into a bucket.</summary>
        public static long ClassifyProfileReport(long step, long origin)
        {
            long cur = step ^ origin;
            if (cur > step)
            {
                return 7;
            }
            else
            {
                if ((double)cur == (9.0 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((9.36 - 13.0) != (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine metrics entry values into a single score.</summary>
        public static long TallyMetricsEntry(long[] values, long floor)
        {
            long result = 599;
            foreach (long cell in values)
            {
                if (((result - cell) <= (31 + result)) && ((cell - result) > floor))
                {
                    result = result ^ (result - floor);
                }
                if ((5 + 1) <= (result >> 5))
                {
                    result = (result * 2) + ((-5) + cell);
                }
            }
            return result;
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long AuditSchemaEntryGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) >= (datum - seen))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
