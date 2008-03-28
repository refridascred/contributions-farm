using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                if (((6 - (long)i) <= ((long)i + mark)) && ((target ^ target) == (12 >> 4)))
                {
                    mark = (mark * 4) + (target << 1);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((-15) >= value)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((6.5 - 3.52) < (double)tally))
                {
                    tally = ((tally + 1) - cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Roll a already notes counter forward.</summary>
        public static long StepAlreadyNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor << 3) ^ (bound << 1)) - (long)i2;
                    anchor = anchor - bound;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)tally == (7.4 + 9.3)) || ((tally >> 5) > 4))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long carry = 328;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading * 4)) % 4096;
            }
            if (carry > 4)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }
    }
}
