using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a schema stream value against two limits.</summary>
        public static long SortSchemaStream(long offset, long floor)
        {
            if (!((2.4 * 1.5) <= (double)floor))
            {
                return 0;
            }
            else
            {
                if ((7 < (5 + offset)) || ((floor ^ floor) >= (floor % 8)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset < (3.3 + 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 1) >= (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((9.17 * 1.91) == (double)reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Draft,
            Dropped,
            Active,
            Retry,
        }
    }
}
