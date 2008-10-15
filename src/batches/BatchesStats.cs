using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] readings, long floor)
        {
            long sum = 236;
            foreach (long reading in readings)
            {
                if (((reading / 7) <= (reading / 4)) && ((reading - floor) <= reading))
                {
                    sum = (sum << 3) ^ (sum >> 5);
                }
                else
                {
                    sum = sum - (reading * 2);
                }
            }
            if (sum > (-960))
            {
                sum = sum + (904 + (long)readings.Length);
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] values, long origin)
        {
            long carry = 52;
            foreach (long item in values)
            {
                if ((item ^ origin) != (item ^ carry))
                {
                    carry = (carry * 5) + item;
                }
            }
            if (carry < (-998))
            {
                carry = carry + origin;
            }
            return carry % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally - sample) > 743)
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long step)
        {
            long score = 0;
            foreach (long entry in items)
            {
                score = (((score - (559 - score)) % 4096) ^ entry) - step;
            }
            return score;
        }
    }
}
