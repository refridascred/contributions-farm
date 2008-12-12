using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry + carry) ^ value;
            }
            return carry % 1000;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph record counter forward.</summary>
        public static long StepGraphRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (796 ^ target)) % 101;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
