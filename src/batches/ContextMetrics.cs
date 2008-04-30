using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings, long target)
        {
            long state = 725;
            foreach (long datum in readings)
            {
                if ((double)datum <= (5.68 - 7.2))
                {
                    state = ((state << 3) ^ state) % 4096;
                }
            }
            if (state > (-7))
            {
                state = (state - target) % 101;
            }
            return state % 65521;
        }

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long AuditFarmFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((-4) + acc) <= (bound + bound)))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (acc + bound)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) != (hits << 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (matches & 1))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
