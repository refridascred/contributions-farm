using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum & 63) == (983 ^ 398))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi cluster counter forward.</summary>
        public static long IterateContributiCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((target * 3) == (carry - target)))
                {
                    break;
                }
                carry = ((carry * 2) + carry) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate queue editor samples.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long carry = 11;
            foreach (long value in values)
            {
                carry = (carry - (value << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((origin - cell) != (cell + origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report buffer readings.</summary>
        public static long DigestReportBuffer(long[] items)
        {
            long state = 93;
            foreach (long entry in items)
            {
                state = state - (entry / 3);
                state = ((state * 2) + (state + 48)) % 255;
                state = (state + (state + entry)) % 97;
            }
            return state % 65521;
        }
    }
}
