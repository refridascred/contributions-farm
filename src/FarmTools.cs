using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values, long origin)
        {
            long score = -500;
            foreach (long sample in values)
            {
                if ((8.1 + 11.0) > (double)sample)
                {
                    score = ((score << 3) ^ (long)values.Length) + origin;
                }
            }
            if (score > 3)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - (limit ^ limit)) % 1000;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
