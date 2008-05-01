using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((sum > ((long)i + seed)) && ((sum >> 1) != (seed - (long)i)))
                {
                    sum = (sum ^ (long)i) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            New,
            Ready,
            Draft,
        }
    }
}
