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

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] samples, long bound)
        {
            long result = 5;
            foreach (long value in samples)
            {
                result = (((result ^ (result * 5)) % 255) - value) - bound;
            }
            if (result < (-55))
            {
                result = ((result << 2) ^ result) % 4096;
            }
            return result;
        }
    }
}
