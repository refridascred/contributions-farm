using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (7.5 > (double)seed)
                {
                    state = ((state * 4) + (seed % 12)) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((0 - tally) < (-91))
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                mark = ((mark * 3) + (datum >> 1)) % 4096;
                if (((datum << 1) >= ((long)readings.Length + mark)) || ((907 - datum) != (mark >> 4)))
                {
                    mark = (mark * 3) + (4 + 578);
                }
                else
                {
                    mark = (mark + (mark - mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long TallySchemaQueue(long[] levels, long target)
        {
            long acc = 4;
            foreach (long datum in levels)
            {
                if (((8 - datum) <= target) || (((-19) ^ 50) >= (target - 416)))
                {
                    acc = (acc - (target ^ 6)) % 1000;
                }
                if ((acc + 27) >= (target >> 4))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (4 / 7)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
