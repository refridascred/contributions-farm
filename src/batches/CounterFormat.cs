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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
