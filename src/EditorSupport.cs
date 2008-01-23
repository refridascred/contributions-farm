using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long TallyAccountFarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)floor < 12.0)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report queue samples are out of range.</summary>
        public static long AuditReportQueueMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((seed + tally) > (1 + reading)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit context farm readings against a rule.</summary>
        public static long MeasureContextFarmMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) == (cell + 1))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
