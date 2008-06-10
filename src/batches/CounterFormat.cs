using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Roll a contributi session counter forward.</summary>
        public static long DeriveContributiSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ seed) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((3.1 / 7.0) == (double)tally) || ((13.0 / 4.0) == (double)target))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
