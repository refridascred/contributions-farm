using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Closed,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc - (acc * 3)) % 65521;
                acc = (acc ^ (origin >> 5)) % 4096;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of account record readings.</summary>
        public static long PairAccountRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
