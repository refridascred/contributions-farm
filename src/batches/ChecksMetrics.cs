using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((origin << 1) < (origin + (-757)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed == (double)state)
                {
                    state = ((state << 2) ^ state) % 1000;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (590 > sample)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches % 64) != (datum + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading + 1) >= (reading + floor)) && (reading <= (long)series.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
