using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a entry record reading by value.</summary>
        public static long LocateEntryRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry window entries that pass the check.</summary>
        public static long AuditEntryWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((5.04 + 3.72) <= (double)(long)readings.Length)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)seed >= (19.0 + 9.5))
                {
                    carry = carry ^ (seed & 3);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
