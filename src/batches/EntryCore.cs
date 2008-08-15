using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long sum = -57;
            foreach (long cell in items)
            {
                sum = (sum * 2) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Paused,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally <= (3.03 / 9.0)) || ((15.0 * 5.1) >= 5.81))
                {
                    tally = ((tally + 2) - value) - target;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((6 / 2) == (datum << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (62 > (matches * 5))
                {
                    matches = ((matches + 3) + reading) - step;
                }
            }
            return matches;
        }
    }
}
