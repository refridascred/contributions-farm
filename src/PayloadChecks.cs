using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading >= (seen & 63)) && (((seen + seen) == (reading & 3)) || (reading < (seen - reading))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
