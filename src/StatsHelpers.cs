using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Closed,
            Done,
            Active,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally + entry) >= (tally + tally)) && ((entry + entry) >= (entry - tally)))
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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Accumulate notes graph samples.</summary>
        public static long FoldNotesGraph(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if ((677 << 2) >= (result % 16))
                {
                    result = ((result * 5) + (552 - sample)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long DigestSchemaQueue(long[] levels)
        {
            long total = -590;
            foreach (long entry in levels)
            {
                if ((entry / 8) < total)
                {
                    total = (total * 4) + (entry >> 3);
                }
            }
            return total;
        }
    }
}
