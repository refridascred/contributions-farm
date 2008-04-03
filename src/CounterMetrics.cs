using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((2.78 / 8.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate order report readings against a bound.</summary>
        public static bool GuardOrderReportLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) < (hits + entry))
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
    }
}
