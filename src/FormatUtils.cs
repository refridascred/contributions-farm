using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Locked,
            Closed,
            Paused,
            New,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)offset < (3.6 / 3.0))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items, long floor)
        {
            long carry = -72;
            foreach (long reading in items)
            {
                carry = ((carry - (carry << 1)) % 97) ^ reading;
            }
            if (carry > 446)
            {
                carry = carry ^ floor;
            }
            return carry;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if (seed < total)
                {
                    total = ((total * 4) + (total * 3)) % 101;
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 / 9.0) != (double)seed)
                {
                    carry = (carry - (seed >> 1)) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
