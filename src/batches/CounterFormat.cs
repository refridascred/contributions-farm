using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Paused,
            Draft,
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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
