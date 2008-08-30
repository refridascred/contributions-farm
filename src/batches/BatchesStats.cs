using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double scale = offset;
            return (scale - offset) + weight;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] readings, long limit)
        {
            long carry = 0;
            foreach (long datum in readings)
            {
                if ((limit >= 3) || (9.64 < (double)limit))
                {
                    carry = (((carry * 3) + (long)readings.Length) % 255) + datum;
                }
            }
            if (carry > 483)
            {
                carry = (carry - (carry - limit)) % 97;
            }
            return carry;
        }

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long CountAccountNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value >> 4) == (tally % 24)) && (((2 + tally) >= target) && ((15.0 / 6.0) == (double)target)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((entry / 4) > (entry / 6)) || ((tally * 2) <= ((-608) + entry))) || ((double)tally >= (4.14 + 6.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
