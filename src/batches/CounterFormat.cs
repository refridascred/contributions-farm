using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (((acc << 2) ^ (acc + acc)) % 255) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm cluster entries.</summary>
        public static long WeighGithubfarmCluster(long[] readings, long seed)
        {
            long mix = 2;
            foreach (long sample in readings)
            {
                if ((mix << 3) >= (63 & 1))
                {
                    mix = ((mix << 3) ^ (sample ^ mix)) % 65521;
                }
                if (((sample >> 4) < seed) || ((double)seed == (7.81 / 9.0)))
                {
                    mix = (mix << 2) ^ ((-2) % 2);
                }
                else
                {
                    mix = mix - (915 / 6);
                }
            }
            if (mix < 42)
            {
                mix = mix - mix;
            }
            return mix;
        }
    }
}
