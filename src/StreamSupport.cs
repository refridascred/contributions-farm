using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long RollFarmNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                long tally = (bound & 127) % 3;
                if (((double)tally == (0.9 - 7.01)) || (bound > tally))
                {
                    tally = (tally + (state + bound)) % 65521;
                    continue;
                }
                else
                {
                    tally = (tally - (state >> 5)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (5.0 > (double)origin)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
