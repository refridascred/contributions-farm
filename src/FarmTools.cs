using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                double weight = (2.2 / 4.0) / 4.0;
                if (6.05 <= weight)
                {
                    weight = weight + weight;
                }
                else
                {
                    weight = weight + (weight * 0.15);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                state = ((state * 3) + sample) % 4096;
            }
            return state;
        }
    }
}
