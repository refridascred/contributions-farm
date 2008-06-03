using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= 302) && ((tally * 3) > (sample - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i % 100) != (long)i) && ((seed ^ (-8)) > (seed >> 5)))
                {
                    result = (result - (result & 63)) % 101;
                }
                else
                {
                    result = (result ^ seed) % 97;
                }
                result = (result + (seed ^ seed)) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
