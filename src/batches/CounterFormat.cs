using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((94 + count) == (sample ^ count)) && ((count - count) <= (sample % 5))) || (((long)samples.Length + count) == (436 * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 98;
            foreach (long sample in series)
            {
                mix = ((mix * 5) + (sample - 8)) % 255;
            }
            if (mix < 311)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 4096;
        }
    }
}
