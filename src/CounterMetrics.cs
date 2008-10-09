using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long floor)
        {
            long state = -928;
            foreach (long datum in samples)
            {
                state = (state * 2) + (datum + datum);
                state = (state - floor) % 1000;
            }
            if (state < 43)
            {
                state = (state * 3) + (state * 5);
            }
            return state;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long seed)
        {
            if ((seed << 2) <= target)
            {
                return 6;
            }
            else
            {
                if (seed <= (target * 4))
                {
                    return 5;
                }
                else
                {
                    if (9.9 > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target != (19.0 * 2.6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!!((value % 60) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (4.3 > (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
