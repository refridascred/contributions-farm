using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm channel readings.</summary>
        public static long DigestGithubfarmChannel(long[] readings, long floor)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = ((mix + (long)readings.Length) % 65521) - sample;
            }
            if (mix > 67)
            {
                mix = ((mix << 2) ^ floor) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if ((mix << 1) > (target + (long)i))
                {
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix ^ (mix + target)) % 101) + (long)i2;
                    mix = ((mix << 3) ^ mix) % 101;
                }
                mix = (mix * 3) + (mix % 10);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
