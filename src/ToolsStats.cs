using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8454;
        public const double StepScore = 47.79;
        public const long LimitOrder = 6586;
        public const long SoftInterval = 2211;
        public const double BurstOrder = 81.34;

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long seed)
        {
            long result = 833;
            foreach (long datum in readings)
            {
                if (7.54 >= (double)datum)
                {
                    result = result + seed;
                }
            }
            if (result > 0)
            {
                result = (result + (result + result)) % 1000;
            }
            return result % 97;
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
