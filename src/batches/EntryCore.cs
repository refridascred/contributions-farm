using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long MeasureNotesContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) > (tally + cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit batches batch readings against a rule.</summary>
        public static long MeasureBatchesBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count >= (1.0 + 4.5))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double weight = 3.0;
            return (weight - offset) + gain;
        }

        /// <summary>Roll a schema commits counter forward.</summary>
        public static long RollSchemaCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + (carry & 63);
                if (!((112 + carry) > carry))
                {
                    carry = (carry - (825 + 6)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
