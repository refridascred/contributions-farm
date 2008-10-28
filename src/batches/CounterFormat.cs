using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (cell & 1)) % 4096;
            }
            if (result > (-9))
            {
                result = (result - (9 * 3)) % 97;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
